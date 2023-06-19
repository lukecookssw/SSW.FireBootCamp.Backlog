import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { WeatherForecast } from './models/weather-forecast';
import { WeatherForecastService } from './services/weather-forecast-service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public weatherForecasts$: Observable<WeatherForecast[]> | undefined;

  constructor(private weatherForecastService: WeatherForecastService){ }

  ngOnInit(){
    this.weatherForecasts$ = this.weatherForecastService.getWeatherForecast()
    // .pipe(tap(x => {
    //   debugger;
    //   console.log(x)}));
  }
}