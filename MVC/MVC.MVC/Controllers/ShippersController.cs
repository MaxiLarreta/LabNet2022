using MVC.Entities;
using MVC.Logic;
using MVC.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            List<Shippers> shippers = logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }

        public ActionResult Insert()
        {

            return View();
        }

        //POST: Shippers/Insert
        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    CompanyName = shippersView.CompanyName,
                    Phone = shippersView.Phone
                };
                logic.Add(shipperEntity);

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
           
            try
            { 
                Shippers shippers = logic.FindOne(id);

                ShippersView shippersView = new ShippersView
                {
                    ID = shippers.ShipperID,
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone
                };
                return View(shippersView);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
            
        }


        /// No encontre la manera de hacer un [HttpPut] de manera correcta, me actualizaba el telefono pero no me redirigia a la pagina y me dejaba el method del header como "POST"
    

        [HttpPost]
        public ActionResult Update(ShippersView shippersView)
        {
            Shippers shipperEntity = new Shippers
            {
                ShipperID = shippersView.ID,
                Phone = shippersView.Phone
            };

            try
            {
                logic.Update(shipperEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}