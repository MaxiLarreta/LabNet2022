import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShipperAddComponent } from './home/addShipper/shipper-add.component';
import { HomeComponent } from './home/home.component';
import { ShipperUpdateComponent } from './home/updateShipper/shipper-update.component';
import { FormComponent } from './components/form/form.component';
import { HttpClientModule } from '@angular/common/http';
import { ShipperService } from './service/shipperService';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ShipperAddComponent,
    ShipperUpdateComponent,
    FormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [ShipperService],
  bootstrap: [AppComponent]
})
export class AppModule { }
