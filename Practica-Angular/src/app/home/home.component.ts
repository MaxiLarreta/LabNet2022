import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { ShipperModel } from '../models/shipperModel';
import { ShipperService } from '../service/shipperService';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnDestroy {

  shippers: ShipperModel[] = [];
  destroy: Subject<void> = new Subject();

  constructor(private router: Router, private shipperService: ShipperService) {
  }

  ngOnInit(): void {
    this.shipperService.getShippers().pipe(takeUntil(this.destroy)).subscribe(shippers => this.shippers = shippers) 
 }

  ngOnDestroy(): void {
    this.destroy.next();
    this.destroy.complete();
  }

  btnClick(): void{
    this.router.navigateByUrl('/shipperAdd');
  }

  btnUpdate(id: number): void {
    this.router.navigateByUrl(`/shipperUpdate/${id}`);
  }

  btnDelete(id : number): void {
    this.shipperService.deleteShipper(id).pipe(takeUntil(this.destroy)).subscribe(res => 
      this.shipperService.getShippers().pipe(takeUntil(this.destroy)).subscribe(shippers => this.shippers = shippers) 
    ) 
  }
}
