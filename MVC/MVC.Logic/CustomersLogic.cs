using MVC.Data;
using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Logic
{
    public class CustomersLogic : BaseLogic, ILogic<Customers, string>
    {
        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public bool Add(Customers newCustomer)
        {
            _context.Customers.Add(newCustomer);

            _context.SaveChanges();
            return true;
        }

        public bool Delete(string id)
        {
            var customerDelete = _context.Customers.Find(id);

            _context.Customers.Remove(customerDelete);

            _context.SaveChanges();
            return true;
        }

        public bool Update(Customers customer)
        {
            var customerUpdate = _context.Customers.Find(customer.CustomerID);

            customerUpdate.Phone = customer.Phone;
            customerUpdate.ContactName = customer.ContactName;

            _context.SaveChanges();
            return true;
        }
    }
}
