import { Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { Book } from '../../types/Book';
import { CartService } from '../../cart/cart.service';
@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrl: './book.component.css'
})
export class BookComponent implements OnInit  {

@Input() book:Book={}as Book;
isInCart:boolean=false;
constructor(private cartService:CartService)
{
}
ngOnInit(): void {
  
}
addToCart()
{ 
  this.isInCart=true;
  console.log("book ca")
  this.cartService.add(this.book)
}
removeFromCart()
{
  this.isInCart=false;
  this.cartService.remove(this.book)
}
}
