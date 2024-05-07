import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor() { }
  getBooks(){
    return [
      {
        name: "clean code",
        author: "Robert C. Martin",
        image: "https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg",
        amount:100
      },
      {
        name: "The Pragmatic P rogrammer",
        author: "David Thomas",
        image: "https://images-na.ssl-images-amazon.com/images/I/41as+WafrFL._SX258_BO1,204,203,200_.jpg",
        amount:200
      }
      ,
      {
        name: "The Pragmatic Programmer",
        author: "David Thomas",
        image: "https://images-na.ssl-images-amazon.com/images/I/41as+WafrFL._SX258_BO1,204,203,200_.jpg",
        amount:200
      }
      ,
      {
        name: "The Pragmatic Programmer",
        author: "David Thomas",
        image: "https://images-na.ssl-images-amazon.com/images/I/41as+WafrFL._SX258_BO1,204,203,200_.jpg",
        amount:200
      }
    ]
  }
}
