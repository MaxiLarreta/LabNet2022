using MVC.Entities;
using MVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.UI
{
    public class CustomersUI
    {
        protected CustomersLogic _customersLogic;
        public CustomersUI()
        {
                _customersLogic = new CustomersLogic();
        }
        public void GetAll()
        {
            Console.WriteLine("*** Customers ***");
            Console.WriteLine(" ");

            foreach (Customers customer in _customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} {customer.CompanyName} - {customer.Phone}");
            }
        }

    }
}
