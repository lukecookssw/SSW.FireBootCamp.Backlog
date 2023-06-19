import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { ApiPaths } from '../../enums/api-paths';
import { catchError, Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {
  private http: HttpClient;
  private weatherForecastUrl: string;

  constructor(http: HttpClient){
    this.http = http;
    this.weatherForecastUrl = environment.baseApiUrl + ApiPaths.WeatherForecast;
  }

  getWeatherForecast(){
    //var healthCheckUrl = this.legalApiUrl + '/HealthCheck';
    var healthCheckUrl = this.weatherForecastUrl;

    return this.http.get(healthCheckUrl, {responseType: 'json'}).pipe(catchError((res: HttpErrorResponse ) => 
    {
      return of(res.error);
    }));
  }
}
