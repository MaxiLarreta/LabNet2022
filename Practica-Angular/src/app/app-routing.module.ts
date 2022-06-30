import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShipperAddComponent } from './home/addShipper/shipper-add.component';
import { HomeComponent } from './home/home.component';
import { ShipperUpdateComponent } from './home/updateShipper/shipper-update.component';

const routes: Routes = [
  { path: "home", component: HomeComponent },
  { path: 'shipperAdd', component: ShipperAddComponent },
  { path: 'shipperUpdate/:id', component: ShipperUpdateComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
