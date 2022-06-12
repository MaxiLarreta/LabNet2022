using Linq.Data;
using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class CustomersLogic
    {
        private readonly NorthwindContext _context;

        public CustomersLogic()
        {
            _context = new NorthwindContext();
        }

        public List <Customers> GetAll()
        {
            return _context.Customers.ToList();
        }
        public Customers GetOne()
        {
            return _context.Customers.First();
        }

        public List<Customers> GetByRegionWA()
        {
            return (from c in _context.Customers
                    where c.Region == "WA"
                    select c).ToList();
        }
        public List<string> GetAllNames()
        {
            return (from c in _context.Customers
                    select c.CompanyName).ToList(); 
        }

        public List<CustomerDTO> JoinWithOrders()
        {
            return (from c in _context.Customers
                    join o in _context.Orders
                    on c.CustomerID equals o.CustomerID
                    where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                    select new CustomerDTO { Region = c.Region, OrderDate = o.OrderDate }).ToList(); 
        }

        public List<Customers> GetThreeCustomersWA()
        {
           return _context.Customers.OrderBy(c => c.Region == "WA").Take(3).ToList();
        }
    }
}
