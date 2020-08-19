import { Component, Testability } from '@angular/core';
import { HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {
  title = 'WebAPIAssignment';
  
  ApiKey = '081703f68fc586caeeee2d7f0f008af4';
  city = 'Ringsted';
  weather;

  constructor(private httpClient:HttpClient){
    this.getWeather();
  }

  getWeather(){
    this.httpClient.get('http://api.openweathermap.org/data/2.5/weather?q='+this.city+'&units=metric'+'&appid=' + this.ApiKey).subscribe(data=>{
      this.weather = data;
      console.log(this.weather);
    })
  }
}