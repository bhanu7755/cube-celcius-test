import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { ResponseModel } from '../models/response.model';

@Injectable({
  providedIn: 'root',
})
export class TemperatureService {

    constructor(private http: HttpClient) { }

    public getConversionValue(from: string, to: string, value: number): Observable<ResponseModel> {
        return this.http.get<ResponseModel>(environment.apiUrl + 'api/TemperatureConversion/Convert?from='+from+'&to='+to+'&value='+value);
      }
}