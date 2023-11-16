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
            string invitationToken = TokenGenerator.GenerateUniqueToken();

            // Create an instance of TokenStorage
            var tokenStorage = new TokenStorage(_context);

            // Call upon SaveTokenInDatabase method from the TokenStorage instance
            tokenStorage.SaveTokenInDatabase(adminEmail, invitationToken);

            bool isEmailSent = await EmailService.SendInvitationEmail(adminEmail, invitationToken);

            if (isEmailSent)
            {
                return RedirectToAction("InvitationSent");
            }
            else
            {
                return View("Error");
            }
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
        public class TokenStorage
        {
            private readonly MyContext _context;

            public TokenStorage(MyContext context)
            {
                _context = context;
            }

            public void SaveTokenInDatabase(string adminEmail, string token)
            {
                DateTime expirationDate = DateTime.UtcNow.AddHours(24);

                var tokenEntity = new Token
                {
                    TokenId = token,
                    UserEmail = adminEmail,  // Change 'userEmail' to 'adminEmail'
                    ExpirationDate = expirationDate
                };

                _context.Tokens.Add(tokenEntity);
                _context.SaveChanges();
            }
        }


        public class TokenValidator
        {
            private readonly MyContext _context;
            public TokenValidator(MyContext context)
            {
                _context = context;
            }
            public bool IsTokenValid(string token)
            {
                var tokenEntity = _context.Tokens.FirstOrDefault(t => t.TokenId == token);

                if (tokenEntity != null)
                {
                    return tokenEntity.ExpirationDate > DateTime.UtcNow;
                }

                return false;
            }
        }


        // EmailService.cs
        public static class EmailService
        {
            public static async Task<bool> SendInvitationEmail(string adminEmail, string token)
            {
                // ... implementation of sending invitation email ...
                return true;
            }
        }

        // Action returning InvitationSent View 
        public IActionResult InvitationSent()
        {
            // ... logic for the InvitationSent action
            return View();
        }

        [HttpGet("Admin/Invite")]
        public IActionResult AdminInvite()
        {
            return View();
        }


        [HttpPost("AdminLogin")]
        public IActionResult AdminLogin(LogAdmin admin)
        {
            _logger.LogInformation("Attempting to log in admin with email: {Email}", admin.Email);

            if (ModelState.IsValid)
            {
                Admin adminInDb = _context.Admins.FirstOrDefault(s => s.Email == admin.Email);

                if (adminInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid login attempt - Email not found");
                    _logger.LogWarning("Invalid login attempt - Email not found: {Email}", admin.Email);
                    LogModelStateErrors();
                    return View("Admin");
                }

                // Use BCrypt.Verify to check the hashed password
                if (!BCrypt.Net.BCrypt.Verify(admin.Password, adminInDb.Password))
                {
                    ModelState.AddModelError("Password", "Invalid login attempt - Incorrect password");
                    _logger.LogWarning("Invalid login attempt - Incorrect password for: {Email}", admin.Email);
                    LogModelStateErrors();
                    return View("Admin");
                }

                // Redirect to the AdminDashboard
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                _logger.LogWarning("Invalid ModelState during admin login");
                LogModelStateErrors();
                return View("Admin");
            }
        }




        private void LogModelStateErrors()
        {
            foreach (var modelState in ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    _logger.LogError("ModelState Error: {ErrorMessage}", error.ErrorMessage);
                }
            }
        }


        [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
        [HttpGet("Admin/Dashboard")]
        public IActionResult AdminDashboard()
        {
            ViewBag.AllOrders = _context.Orders.Include(i => i.OrderedBy).ToList();
            return View();
        }

        [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
        [HttpGet("OrderInfo/{oId}")]
        public IActionResult OrderInfo(int oId)
        {
            ViewBag.OrderInfo = _context.Orders.Include(w => w.Products)
            .FirstOrDefault(i => i.OrderId == oId);
            return View();
        }

        // [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
        [HttpGet("Admin/Products")]
        public IActionResult AdminProducts()
        {
            ViewBag.AllProducts = _context.Products.Include(a => a.MediaType).OrderByDescending(w => w.ProductId).ToList();
            return View();
        }

        // [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
        [HttpGet("NewProduct")]
        public IActionResult NewProduct()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View();
        }

        // [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
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

        // [Authorize(Roles = "Admin", Policy = "AdminPolicy")]
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



