import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { PostShipperModel } from "../models/postShipperModel";
import { ShipperModel } from "../models/shipperModel";

@Injectable()
export class ShipperService {

  readonly API = 'https://localhost:44315/api/Shippers';

  constructor(private httpClient: HttpClient) { }

  getShippers() {
    return this.httpClient.get(`${this.API}`).pipe(map((response: any) => response ? response : []))
  }

  getShipperById(id : string) {
    return this.httpClient.get(`${this.API}/${id}`).pipe(map((response: any) => response ? response : {}))
  }
  
  postShipper(shipper : PostShipperModel){
    return this.httpClient.post(`${this.API}`, shipper).pipe(map((response: any) => response ? response : ""))
  }

  updateShipper(shipper : ShipperModel){
    return this.httpClient.put(`${this.API}`, shipper).pipe(map((response: any) => response ? response : ""))
  }

  deleteShipper(id : number) {
    return this.httpClient.delete(`${this.API}/${id}`).pipe(map((response: any) => response ? response : ""))
  }

}