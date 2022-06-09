using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LogicTests
{
    public class InMemoryShippers
    {
        private List<Shippers> _db = new List<Shippers>();
        public Exception ExceptionToThrow { get; set; }
        public IEnumerable<Shippers> GetAllShippers()
        {
            return _db.ToList();
        }
        public Shippers GetShipperByID(int id)
        {
            return _db.FirstOrDefault(d => d.ShipperID == id);
        }
        public void CreateNewShipper(Shippers shipperToCreate)
        {
            if (ExceptionToThrow != null)
                throw ExceptionToThrow;
            _db.Add(shipperToCreate);
        }
        public void DeleteShipper(int id)
        {
            _db.Remove(GetShipperByID(id));
        }
    }
}
