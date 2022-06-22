using MVC.Entities;
using MVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppi.Service.Interface;

namespace WebAppi.Service
{
    public class ShippersService : IShippersService
    {
        private readonly ShippersLogic _repository;
        public ShippersService()
        {
            _repository = new ShippersLogic();
        }

        public void Add(Shippers shipper)
        {
            _repository.Add(shipper);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Shippers> GetAll()
        {
           return _repository.GetAll();
        }

        public Shippers GetById(int id)
        {
            return _repository.FindOne(id);
        }

        public void Update(Shippers shipper)
        {
            _repository.Update(shipper);
        }
    }
}
