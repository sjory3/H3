import { Component, OnInit } from '@angular/core';
import{Element} from '../element';
import { ElementServiceService } from '../element-service.service';

@Component({
  selector: 'app-periodic-table',
  templateUrl: './periodic-table.component.html',
  styleUrls: ['./periodic-table.component.css']
  
})
export class PeriodicTableComponent implements OnInit {

  constructor(private elementservice: ElementServiceService) { }

  elements:Element[]=[];

  ngOnInit(): void {
    this.elements = this.elementservice.MapData();
  }
}
