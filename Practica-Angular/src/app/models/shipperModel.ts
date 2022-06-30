export class ShipperModel {
    public ShipperID : number;
    public CompanyName : string;
    public Phone : string;

    constructor(shipperId: number, companyName: string, phone: string) {
        this.ShipperID = shipperId,
        this.CompanyName  = companyName,
        this.Phone = phone
    }
}