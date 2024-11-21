import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { AuthService } from '@abp/ng.core';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss',
})
export class NavbarComponent {
  [x: string]: any;
  isMenuOpen = false;
  logoPath = 'assets/images/logo.png';

  constructor(private router: Router, private authService: AuthService) {}

  toggleMenu() {
    this.isMenuOpen = !this.isMenuOpen;
  }

  redirectTo(route: string) {
    this.router.navigate([`/${route}`]);
  }

  isRouteActive(route: string): boolean {
    return this.router.url === `/${route}`;
  }

  login(): void {
    this.authService.navigateToLogin();// Método para manejar la autenticación
  }
}



