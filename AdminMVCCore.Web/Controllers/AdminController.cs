using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdminMVCCore.BL;
using AdminMVCCore.Entities.Tables;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AdminMVCCore.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _admin;
        public AdminController(IAdminManager admin)
        {
            _admin = admin;
        }
       
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
            
        }
        public async Task<IActionResult> Login(Admin admn)
        {
            int id = _admin.Login(admn);
            if (id != 0)
            {
                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name,admn.AdminName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");


            }
            else
            ViewBag.hata = "Kullanıcı Adı veya Şifreyi Yanlış Girdiniz";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
    }
}