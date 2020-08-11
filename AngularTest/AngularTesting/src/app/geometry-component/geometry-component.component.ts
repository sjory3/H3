import { Component, OnInit } from '@angular/core';
import {Geometry} from 'src/app/geometry';
import {Rectangle} from 'src/app/rectangle';
import {Square} from 'src/app/square';

@Component({
  selector: 'app-geometry-component',
  templateUrl: './geometry-component.component.html',
  styleUrls: ['./geometry-component.component.css']
})
export class GeometryComponentComponent implements OnInit {

  sideAValue : number = 0;
  sideBValue : number = 0;

  areaValue : number = 0;
  perimeterValue : number = 0;

  sideA(event: any){this.sideAValue = event.target.value};
  sideB(event: any){this.sideBValue = event.target.value};

  Calculate(){
    let figur =  new Square(this.sideAValue, this.sideBValue);
    this.areaValue = figur.Area();
    this.perimeterValue = figur.Perimeter();
  }

  constructor() { }

  ngOnInit(): void {
  }

}
