import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
  constructor(private router:Router) {}

  ngOnInit(): void {
    // Initialization logic can go here
  }

  onLogin(): void {
    
    this.router.navigate(['/admin/admin-home']);
    this.router.navigate(['/user/user-home']);
  }

  onRegister(): void {
    // Handle registration logic
  }

}
