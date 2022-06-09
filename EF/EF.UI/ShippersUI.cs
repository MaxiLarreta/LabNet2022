using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    public class ShippersUI
    {
        protected ShippersLogic _shippersLogic;
        public List<string> idShippers { get; set; }
        public ShippersUI()
        {
            _shippersLogic = new ShippersLogic();
            idShippers = new List<string> { };

        }

        public void GetAll()
        {
            Console.WriteLine("*** Shippers ***");
            foreach (Shippers shipper in _shippersLogic.GetAll())
            {
               
                Console.WriteLine($"{shipper.ShipperID} {shipper.CompanyName} - {shipper.Phone}");
                if (idShippers.Contains(shipper.ShipperID.ToString()) == false)
                {
                    idShippers.Add(shipper.ShipperID.ToString());
                }
            }
        }

        public void Add(string shipperCompanyName, string shipperPhone)
        {
            _shippersLogic.Add(new Shippers
            {
                CompanyName = shipperCompanyName,
                Phone = shipperPhone
            });
        }

        public void Update(int shipperId, string shipperPhone)
        {
            _shippersLogic.Update(new Shippers
            {
                ShipperID = shipperId,
                Phone = shipperPhone
            });
        }
        public void Delete(int shipperId)
        {
            _shippersLogic.Delete(shipperId);
            idShippers.Remove(shipperId.ToString());
        }

    }
}
