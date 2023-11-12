using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace CSharpProject.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public AdminController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        //===========================================================================
        // Admin Routes
        //===========================================================================

        [HttpGet("Admin")]
        public IActionResult Admin()
        {
            return View();
        }

        [HttpPost("AdminLogin")]
        public IActionResult AdminLogin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                Admin AdminInDb = _context.Admins.FirstOrDefault(s => s.Email == admin.Email);
                if (AdminInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid login attempt");
                    return View("Admin");
                }
                // PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                // PasswordVerificationResult result = Hasher.VerifyHashedPassword(LogUser, UserInDb.Password, LogUser.LogPassword);
                if (AdminInDb.Password != admin.Password)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt");
                    return View("Admin");
                }
                HttpContext.Session.SetInt32("AdminId", admin.AdminId);
                return RedirectToAction("Admin/Dashboard");
            }
            else
            {
                return View("Admin");
            }
        }



        [HttpGet("Admin/Dashboard")]
        public IActionResult AdminDashboard()
        {
            ViewBag.AllOrders = _context.Orders.Include(i=>i.OrderedBy).ToList();
            return View();
        }

        [HttpGet("OrderInfo/{oId}")]
        public IActionResult OrderInfo(int oId)
        {
            ViewBag.OrderInfo = _context.Orders.Include(w=>w.Products)
            .FirstOrDefault(i=>i.OrderId == oId);
            return View();
        }

        [HttpGet("Admin/Products")]
        public IActionResult AdminProducts()
        {
            ViewBag.AllProducts = _context.Products.Include(a=>a.MediaType).OrderByDescending(w=>w.ProductId).ToList();
            return View();
        }

        [HttpGet("NewProduct")]
        public IActionResult NewProduct()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct (Product NewProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(NewProduct);
                _context.SaveChanges();
                return Redirect("/Admin/Products");
            }
            else
            {
                return View("NewProduct");
            }
        }

        [HttpPost("NewCategory")]
        public IActionResult NewCategory(Category NewCategory)
        {
            _context.Categories.Add(NewCategory);
            _context.SaveChanges();
            return RedirectToAction("NewProduct");
        }

















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



