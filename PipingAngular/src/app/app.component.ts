import { Component } from '@angular/core';
import { ConverterPipe} from 'src/app/converter.pipe'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  result:string;
  input:string;

  onClick(){
    this.result = this.input;
  }
}
