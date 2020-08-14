import { Injectable } from '@angular/core';
import { Element } from './element';
import { HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ElementServiceService {
  //private httpClient: HttpClient
  constructor(private httpClient: HttpClient) { }
  
  elements:Element[]=[]


  MapData(): void {
    this.httpClient.get('https://neelpatel05.pythonanywhere.com/').subscribe(data=>{
      console.log(data);
    })
  }
  }
/*
    data.elements.forEach(element => {
    let tempElement = new Element(
      element.name,
      element.symbol,
      element.atomic_mass,
      element.number,
      element.phase
    );
    console.log('mapData called');
    console.log(tempElement.name);
    this.elements.push(tempElement);
    });
  */
