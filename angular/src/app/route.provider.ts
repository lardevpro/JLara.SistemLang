import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      }, {
        path: '/contact',
        name: '::Menu:Contact',
        // iconClass: 'fas fa-home',
        order: 2,
        layout: eLayoutType.application,
      }, {
        path: '/courses',
        name: '::Menu:Courses',
        // iconClass: 'fas fa-home',
        order: 3,
        layout: eLayoutType.application,
      }, {
        path: '/languages',
        name: '::Menu:Languages',
        // iconClass: 'fas fa-home',
        order: 4,
        layout: eLayoutType.application,
      },{
        path: '/about',
        name: '::Menu:About',
        // iconClass: 'fas fa-home',
        order: 4,
        layout: eLayoutType.application,
      },{
        path: '/progress',
        name: '::Menu:Progress',
        // iconClass: 'fas fa-home',
        order: 4,
        layout: eLayoutType.application,
        requiredPolicy: "SistemLang.Progress"
      },{
        path: '/learning',
        name: '::Menu:Learning',
        // iconClass: 'fas fa-home',
        order: 4,
        layout: eLayoutType.application,
        requiredPolicy: "SistemLang.Exercise"
      },
    ]);
  };
}
