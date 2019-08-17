import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SomarComponent } from './components/somar/somar.component';
import { SubtrairComponent } from './components/subtrair/subtrair.component';
import { MultiplicarComponent } from './components/multiplicar/multiplicar.component';
import { DividirComponent } from './components/dividir/dividir.component';

const routes: Routes = [
  {
    path: "somar",
    component: SomarComponent
  },
  {
    path: "subtrair",
    component: SubtrairComponent
  },
  {
    path: "multiplicar",
    component: MultiplicarComponent
  },
  {
    path: "dividir",
    component: DividirComponent
  }
]

@NgModule({
  declarations: [
    AppComponent,
    SomarComponent,
    SubtrairComponent,
    MultiplicarComponent,
    DividirComponent
 ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [ ],
  bootstrap: [AppComponent]
})
export class AppModule { }
