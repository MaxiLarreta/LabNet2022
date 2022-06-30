using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;
using WebAppi.Service;

namespace WebApi.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShippersController : ApiController       
    {
        private readonly ShippersService _service;
        public ShippersController()
        {
            _service = new ShippersService();
        }

        //GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            try
            {
                var shippersList = _service.GetAll().Select(s => new ShippersModel
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();
                return Ok(shippersList);
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        //GET: api/Shippers/{id}
        public IHttpActionResult GetShipper(int id)
        {
            if (id < 0)
            {
                BadRequest("Please enter valid Shipper ID");
            };
            try
            {
                Shippers shipper = _service.GetById(id);
                var response = new ShippersModel
                {
                    ShipperID = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        //POST: api/Shippers
        public IHttpActionResult PostShipper([FromBody] ShippersModelPost shippers)
        {
            try
            {
                var shipper = new Shippers
                {
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone,
                };
                _service.Add(shipper);
                
                return Content(HttpStatusCode.Created, shipper);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotModified, ex.Message);
            }
        }

        [HttpPut]   
        //PUT: api/Shippers
        public IHttpActionResult UpdateShipper([FromBody] ShippersModelPut shippers)
        {
            try
            {
                var shipper = new Shippers
                {
                    ShipperID = shippers.ShipperID,
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone,
                };
                _service.Update(shipper);

                return Ok(shippers);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotModified, ex.Message);
            }
        }

        //DELETE: api/Shippers/{id}
        public IHttpActionResult DeleteShipper(int id)
        {
            if (id < 0) 
            {
                BadRequest("Please enter valid Shipper ID");
            };

            try
            {
                _service.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotModified, ex.Message);
            }
        }

    }
}
