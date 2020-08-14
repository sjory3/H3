import { Component, OnInit } from '@angular/core';
import{ Dictator } from '../dictator'

@Component({
  selector: 'app-dictator-form',
  templateUrl: './dictator-form.component.html',
  styleUrls: ['./dictator-form.component.css']
})
export class DictatorFormComponent implements OnInit {

  dictatorList: Dictator[]=[];

  firstName:String;
  lastName:String;
  birthDate:Date;
  deathDate:Date;

  constructor() { }

  ngOnInit(): void {
  }

  AddDictator(){
    let dic = new Dictator(this.firstName,this.lastName,this.birthDate,this.deathDate);
    console.log('Made a Dictator ' + dic.firstName + ', ' + dic.lastName);
    this.dictatorList.push(dic);
    console.log(this.dictatorList);
  }

  deleteDictator(number:number){
    this.dictatorList.splice(number ,1);
  }

}
