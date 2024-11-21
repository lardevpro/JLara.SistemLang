import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <app-navbar></app-navbar>
      <main>
        <router-outlet></router-outlet> <!-- Contenido dinámico según la ruta -->
      </main>
    <app-footer></app-footer>
  `,
})
export class AppComponent {}
