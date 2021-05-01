import { Component, OnDestroy } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {MatDialog} from '@angular/material/dialog';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { AlertDialogComponent } from './alert-dialog.component';
import { TemperatureService } from './services/temperature.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnDestroy{
  
  public form: FormGroup = new FormGroup({
    from: new FormControl('', Validators.required),
    to: new FormControl('', Validators.required),
    value: new FormControl('', Validators.required)
  });
  private ngUnsubscribe: Subject<void> = new Subject<void>();
  public result: number= 0;
  public isVisible: boolean = false;

  constructor(public dialog: MatDialog, public tempService: TemperatureService) {}

  public submit() {
    if (this.form.valid) {
      let from: string = this.form.controls["from"].value;
      let to: string = this.form.controls["to"].value;
      
      if(isNaN(this.form.controls["value"].value)) {
        this.dialog.open(AlertDialogComponent, {
          data: { message: 'Value must be number' },
        });
      } else if(from === to) {
        this.dialog.open(AlertDialogComponent, {
          data: { message: 'From and To cannot be same' },
        });
      } else {
        let value: number = parseFloat(this.form.controls["value"].value);
        this.tempService.getConversionValue(from, to, value)
        .pipe(takeUntil(this.ngUnsubscribe))
        .subscribe(res => {
          this.isVisible = true;
          this.result = res.result;
        });
      }
    }
  }

  public ngOnDestroy(): void {
    this.ngUnsubscribe.next();
    this.ngUnsubscribe.complete();
  }
}
