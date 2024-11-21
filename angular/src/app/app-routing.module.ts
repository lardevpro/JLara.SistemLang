import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadComponent: () => import('./home/home.component').then(m => m.HomeComponent),
  },
  {
    path: 'contact',
    loadComponent: () => import('./components/contact/contact.component').then(m => m.ContactComponent),
  },
  {
    path: 'courses',
    loadComponent: () => import('./components/courses/courses.component').then(m => m.CoursesComponent),
  },
  {
    path: 'languages',
    loadComponent: () => import('./components/languages/languages.component').then(m => m.LanguagesComponent),
  }
  ,
  {
    path: 'about',
    loadComponent: () => import('./components/about/about.component').then(m => m.AboutComponent),
  },
  {
    path: 'learning',
    loadComponent: () => import('./components/learning/learning.component').then(m => m.LearningComponent),
  },
  { path: '', redirectTo: '/home', pathMatch: 'full' 
  }, // Ruta principal
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {})],
  exports: [RouterModule],
})
export class AppRoutingModule {}
