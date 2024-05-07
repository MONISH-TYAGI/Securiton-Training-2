import { Component  } from "@angular/core"
import { initializeApp } from "firebase/app"
import { firebaseConfig } from "./types/firebase.config"
import { AuthService } from './auth/auth.service';

@Component({
    selector:'app-root',
    templateUrl:'app.component.html',
    styleUrls:['app.component.css']
})
export class AppComponent{
    constructor(private authService: AuthService) {}
    ngOnInit():void
    {
        initializeApp(firebaseConfig)
    }
    isAuthenticated()
    {
        return this.authService.isAuthenticated;
    }
    logout()
    {
        this.authService.logout();
    }
}