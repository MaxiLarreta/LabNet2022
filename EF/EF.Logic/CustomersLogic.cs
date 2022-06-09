using EF.Data;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public class CustomersLogic : BaseLogic, ILogic<Customers, string>
    {
        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Add(Customers newCustomer)
        {
            _context.Customers.Add(newCustomer);

            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var customerDelete = _context.Customers.Find(id);

            _context.Customers.Remove(customerDelete);

            _context.SaveChanges();
        }

        public void Update(Customers customer)
        {
            var customerUpdate = _context.Customers.Find(customer.CustomerID);

            customerUpdate.Phone = customer.Phone;
            customerUpdate.ContactName = customer.ContactName;

            _context.SaveChanges();
        }
    }
}
