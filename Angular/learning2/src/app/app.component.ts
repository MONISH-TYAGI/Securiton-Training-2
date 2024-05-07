import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})  
export class AppComponent {
  title = 'learning1';
  data:string="";
  name:string="monish";
  disable1=true;
  disable2=false; 
  color="red";
  color2="green";
  show=false;
  getData(param:string){
    console.warn(param);
    this.data=param;
  }
  users=['Anil','Bhaker','Sam'];
  userDetails=[
 { name :'Anil', age: 25, email:'anil@gmail.com'},
 { name :'Bhaker', age: 26, email:'bhaker@gmail.com'},
 { name :'Sam', age: 27, email:'Sam@gmail.com'}
  ];
}
