using EF.Data;
using EF.Entities;
using EF.Logic.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers, int>
    {
        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
        public void Add(Shippers newShipper)
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
        }
        public void Delete(int id)
        {
            var shipperDelete = _context.Shippers.Find(id);

            _context.Shippers.Remove(shipperDelete);

            _context.SaveChanges();
        }

        public void Update(Shippers shipper)
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
            shipperUpdate.Phone = shipper.Phone;

            _context.SaveChanges();
        }
    }
}
