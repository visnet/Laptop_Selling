import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { LaptopFormComponent } from './laptop-form/laptop-form.component';
import { HeaderComponent } from './header/header.component';
import { LaptopListComponent } from './laptop-list/laptop-list.component';
import { DeleteConfirmComponent } from './delete-confirm/delete-confirm.component';




@NgModule({
  declarations: [
    AppComponent,
    LaptopFormComponent,
    HeaderComponent,
    LaptopListComponent,
    DeleteConfirmComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
