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
        //===============
        // Admin Registration Controls
        //===============

        // Send Invitation

        [HttpPost("SendInvitation")]
        public async Task<IActionResult> SendInvitation(string adminEmail)
        {
            // create a string variable invitationToken, set it to the result of calling GenerateUniqueToken() method of TokenGenerator Class
            string invitationToken = TokenGenerator.GenerateUniqueToken();
            // Call upon SaveTokenInDatabase method from TokenStorage Class, and pass in the email that invite is being sent to, and the invitationToken
            TokenStorage.SaveTokenInDatabase(adminEmail, invitationToken);
            // asychronous function to call SendInvitationEmail method from EmailService class, passing in adminEmail, and invitationToken
            await EmailService.SendInvitationEmail(adminEmail, invitationToken);
            // redirect to Invitation Sent
            return RedirectToAction("InvitationSent");
        }

        // TokenGenerator.cs
        public static class TokenGenerator
        {
            public static string GenerateUniqueToken()
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var random = new Random();

                // Generate a token of length 32 characters

                // creates an enumerable sequence that repeats the characters in the chars string 32 times.
                string token = new string(Enumerable.Repeat(chars, 32)
                    // randomly select one character from each repetition and generates a random index within the length of each repetition
                    .Select(s => s[random.Next(s.Length)])
                    // converts the sequence of characters into an array.
                    .ToArray());
                    
                return token;
            }
        }

        // TokenStorage.cs
        public static class TokenStorage
        {
            public static void SaveTokenInDatabase(string adminEmail, string token)
            {
                // ... implementation of saving token in the database ...
            }
        }

        // EmailService.cs
        public static class EmailService
        {
            public static Task SendInvitationEmail(string adminEmail, string token)
            {
                // ... implementation of sending invitation email ...
            }
        }

        // Action returning InvitationSent View 
        public IActionResult InvitationSent()
        {
            // ... logic for the InvitationSent action
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
            ViewBag.AllOrders = _context.Orders.Include(i => i.OrderedBy).ToList();
            return View();
        }

        [HttpGet("OrderInfo/{oId}")]
        public IActionResult OrderInfo(int oId)
        {
            ViewBag.OrderInfo = _context.Orders.Include(w => w.Products)
            .FirstOrDefault(i => i.OrderId == oId);
            return View();
        }

        [HttpGet("Admin/Products")]
        public IActionResult AdminProducts()
        {
            ViewBag.AllProducts = _context.Products.Include(a => a.MediaType).OrderByDescending(w => w.ProductId).ToList();
            return View();
        }

        [HttpGet("NewProduct")]
        public IActionResult NewProduct()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product NewProduct)
        {
            if (ModelState.IsValid)
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



