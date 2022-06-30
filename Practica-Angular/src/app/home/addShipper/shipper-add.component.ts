import { Component, OnDestroy } from '@angular/core';
import { Subject } from 'rxjs';
import { PostShipperModel } from 'src/app/models/postShipperModel';
import { ShipperService } from 'src/app/service/shipperService';
import { takeUntil } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.css']
})

export class ShipperAddComponent implements OnDestroy{

  destroy: Subject<void> = new Subject();

  constructor(private shipperService: ShipperService, private router: Router) {}

  onSubmit(data: any) : void {
    let newShipper = new PostShipperModel(data.name, data.phone)
    this.shipperService.postShipper(newShipper).pipe(takeUntil(this.destroy)).subscribe(resp =>  this.router.navigateByUrl('/home'));
    
  }

  ngOnDestroy(): void {
    this.destroy.next();
    this.destroy.complete();
  }

 
}
