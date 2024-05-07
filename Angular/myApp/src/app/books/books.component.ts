import { Component, OnInit } from '@angular/core';
 import { Book } from '../types/Book';
import { BooksService } from './books.service';



@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrl: './books.component.css'
})
export class BooksComponent implements OnInit {
  books: Book[] = [];
constructor(private booksService: BooksService) {
}
ngOnInit(): void {
  this.books = this.booksService.getBooks();
}


name:string="Clean Code";
author:string="Robert C. Martin";
src:string="https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg";
name2:string="The Pragmatic Programmer";
author2:string="David Thomas";
src2:string="https://images-na.ssl-images-amazon.com/images/I/41as+WafrFL._SX258_BO1,204,203,200_.jpg";
isDisabled:boolean=false;

handleClick(){
  alert("Button Clicked")
  // this.isDisabled=!this.isDisabled;
}
myName:string="";
isShow:boolean=true;

handleInput(event:any)
{
  this.myName=event.target.value;
}
// addToCart(book://   console.log('add')
//   console.log(book)

// }

}
