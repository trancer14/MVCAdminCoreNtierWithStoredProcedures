using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminMVCCore.Web.Models;
using AdminMVCCore.BL;
using AdminMVCCore.Entities.Tables;
using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace AdminMVCCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerManager _customer;
        public HomeController(ICustomerManager customer)
        {
            _customer = customer;
        }
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var musteriler=_customer.Get();
            
            return View(musteriler);
        }
        public IActionResult Delete(int id)
        {
            Customer finded = _customer.Find(id);
            if (finded != null)
            {
                _customer.Delete(id);
                return RedirectToAction("Index");
            }
            else
                return View("Error");
           

        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _customer.Create(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Customer updated = _customer.Find(id);
            if (updated != null)
            {
                return View(updated);
            }
            else
                return View("Error");
           
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            _customer.Update(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
