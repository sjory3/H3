import { Injectable } from '@angular/core';
import { Element } from './element';
import { HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ElementServiceService {
  //private httpClient: HttpClient
  constructor(private httpClient: HttpClient) {
    console.log('Element service called')
  }
    request;
    elements:Element[]=[]
  
  public MapData(): Element[] {
    console.log('MapData Called')
    this.httpClient.get('https://neelpatel05.pythonanywhere.com/').subscribe(data=>{
    this.request = data;
    for (let index = 0; index < 118; index++) {
      let tempElement = new Element(
        this.request[index].name,
        this.request[index].symbol,
        this.request[index].atomicMass,
        this.request[index].atomicNumber,
        this.request[index].standardState
      )
      this.elements.push(tempElement);
      }  
    })
    return this.elements;
  }
}
