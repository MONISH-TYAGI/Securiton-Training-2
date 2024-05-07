import { Component } from '@angular/core';
import { RegisterForm } from '../../types/auth';
import { OnInit } from '@angular/core';

// import { AuthService } from '../../auth.service';
import { getAuth, createUserWithEmailAndPassword } from "firebase/auth";
import { AuthService } from '../auth.service';
// import { AuthService } from '../auth.service';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'] // Fix: Assign an array of strings
})
export class RegisterComponent implements OnInit{
  form:RegisterForm={
    email:'',
    password:'',
    confirm_password:'',
  }
  passwordMatched: boolean = true;

  constructor(private authService: AuthService) {}

  ngOnInit(): void {}

  submit() {
    this.authService.register(this.form);
  }

  isLoading() {
    return this.authService.isLoading;
  }
}

