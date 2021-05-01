
import {Component, Inject} from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
    selector: 'alert-dialog',
    templateUrl: 'alert-dialog.component.html',
  })
  export class AlertDialogComponent {
    constructor(@Inject(MAT_DIALOG_DATA) public data: {message: string}) { }
  }