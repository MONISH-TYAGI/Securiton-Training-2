import { Component } from '@angular/core';
import {LoginForm} from '../../types/auth';
// import { AuthService } from '../auth.servi/ce';
import { getAuth, signInWithEmailAndPassword } from "firebase/auth"
import { AuthService } from '../auth.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
form:LoginForm={
  email:'',
  password:'',
}

constructor(private authService: AuthService) {}

  ngOnInit(): void {}

  submit() {
    this.authService.login(this.form);
  }

  isLoading() {
    return this.authService.isLoading;
  }
}
