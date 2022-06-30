import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ShipperModel } from 'src/app/models/shipperModel';
import { ShipperService } from 'src/app/service/shipperService';
import { takeUntil } from 'rxjs/operators';
import { Subject } from 'rxjs';

@Component({
  selector: 'shipper-update',
  templateUrl: './shipper-update.component.html',
  styleUrls: ['./shipper-update.component.css']
})

export class ShipperUpdateComponent implements OnInit, OnDestroy {

  public id: string | null;
  public shipper : ShipperModel;
  destroy: Subject<void> = new Subject();

 constructor(private route: ActivatedRoute, private shipperService: ShipperService, private router: Router) {
  this.id = this.route.snapshot.paramMap.get('id'); 
 }

  ngOnInit() {
    this.shipperService.getShipperById(this.id ? this.id : "1").pipe(takeUntil(this.destroy)).subscribe(shipper => this.shipper = shipper)
  }

  ngOnDestroy(): void {
    this.destroy.next();
    this.destroy.complete();
  }
  
  onSubmit(data: any) : void {
    let updatedShipper : ShipperModel = new ShipperModel(this.id ? +this.id : 1, data.name, data.phone)

    this.shipperService.updateShipper(updatedShipper).pipe(takeUntil(this.destroy)).subscribe(res => this.router.navigateByUrl('/home'))
  }
}
