
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { DataListComponent } from './components/data-list/data-list.component';
import { DataService } from './services/data.service';

@NgModule({
  declarations: [
    AppComponent,
    DataListComponent,
    // ...otros componentes...
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    // ...otros módulos...
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }