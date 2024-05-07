import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'HospitalManagementSystem';
  someValue:string="";
  someValues:Array<string>=new Array<string>();
  CallSomeLogic(){
    this.someValues.push(this.someValue)
    this.someValue="";
    alert("Hello")
  }
}
