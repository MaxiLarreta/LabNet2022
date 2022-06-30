
using MVC.Common.CustomExceptions;
using MVC.Data;
using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers, int>
    {
        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public Shippers FindOne(int? id)
        {
            var shipper = _context.Shippers.Find(id);
            if (shipper == null)
            {
                throw new ShipperNullException();
            }
            return shipper;
        }
        public bool Add(Shippers newShipper)
        {
            if (string.IsNullOrWhiteSpace(newShipper.CompanyName))
            {
                throw new CompanyNameEmptyException();
            }
            if (string.IsNullOrWhiteSpace(newShipper.Phone))
            {
                throw new PhoneEmptyException();
            }
            _context.Shippers.Add(newShipper);

            _context.SaveChanges();
            return true;    
        }
        public bool Delete(int id)
        {
            var shipperDelete = _context.Shippers.Find(id);

            if (shipperDelete == null)
            {
                throw new ShipperNullException();
            }

            _context.Shippers.Remove(shipperDelete);

            _context.SaveChanges();
            return true;
        }

        public bool Update(Shippers shipper)
        {
            var shipperUpdate = _context.Shippers.Find(shipper.ShipperID);

            if(shipperUpdate == null)
            {
                throw new ShipperNullException();
            }
            if (string.IsNullOrWhiteSpace(shipper.Phone))
            {
                throw new PhoneEmptyException();
            }
            if (string.IsNullOrWhiteSpace(shipper.CompanyName))
            {
                throw new PhoneEmptyException();
            }

            shipperUpdate.Phone = shipper.Phone;
            shipperUpdate.CompanyName = shipper.CompanyName;

            _context.SaveChanges();
            return true;
        }
    }
}
