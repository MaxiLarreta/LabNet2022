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
        // GET: Shippers
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            List<Shippers> shippers = logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }
    }
}