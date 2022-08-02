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
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // HttpContext.Session.Clear();
            ViewBag.AllProducts = _context.Products.ToList();
            ViewBag.LoggedIn = false;
            return View();
        }


        [HttpPost("Register")]
        public IActionResult Register(User NewUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(e => e.Email == NewUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                _context.Users.Add(NewUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", NewUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.LoggedIn = false;
                return View("Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LogUser LogUser)
        {
            if (ModelState.IsValid)
            {
                User UserInDb = _context.Users.FirstOrDefault(s => s.Email == LogUser.LogEmail);
                if (UserInDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid login attempt");
                    return View("Index");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(LogUser, UserInDb.Password, LogUser.LogPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LogPassword", "Invalid login attempt");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", UserInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == HttpContext.Session.GetInt32("UserId"));
                ViewBag.LoggedIn = false;
                return View("Index");
            }
        }


        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(d => d.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }














        [HttpGet("{pId}/info")]
        public IActionResult ProductInfo(int pId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.ProductInfo = _context.Products.FirstOrDefault(p => p.ProductId == pId);
            return View();
        }


        [HttpGet("AddToCart/{pId}")]
        public IActionResult AddToCart(int pId)
        {
            int LoggedInUserId = (int)HttpContext.Session.GetInt32("UserId");
            ShoppingCart NewShoppingCartItem = new ShoppingCart();
            NewShoppingCartItem.UserId = LoggedInUserId;
            NewShoppingCartItem.ProductId = pId;
            _context.ShoppingCarts.Add(NewShoppingCartItem);
            _context.SaveChanges();
            return Redirect("/ShoppingCart/");
        }

        [HttpGet("ShoppingCart")]
        public IActionResult ShoppingCart()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            int LoggedInUserId = (int)HttpContext.Session.GetInt32("UserId");
            ViewBag.LoggedInUser = _context.Users.FirstOrDefault(c => c.UserId == LoggedInUserId);
            ViewBag.ShoppingCart = _context.Users.Include(w => w.UserCart)
            .ThenInclude(w => w.CartItem)
            .FirstOrDefault(a => a.UserId == LoggedInUserId);
            return View();
        }

        [HttpGet("RemoveFromCart/{sId}")]
        public IActionResult RemoveFromCart(int sId)
        {
            int LoggedInUserId = (int)HttpContext.Session.GetInt32("UserId");
            // ShoppingCart ItemToRemove = _context.ShoppingCarts.FirstOrDefault(c=>c.ProductId == pId && c.UserId == LoggedInUserId);
            // _context.ShoppingCarts.Remove(ItemToRemove);
            ShoppingCart ItemToRemove = _context.ShoppingCarts.FirstOrDefault(s => s.ShoppingCartId == sId);
            _context.ShoppingCarts.Remove(ItemToRemove);
            _context.SaveChanges();
            return Redirect("/ShoppingCart/");
        }

        [HttpPost("/PlaceOrder")]
        public IActionResult PlaceOrder(Order NewOrder)
        {

            int LoggedInUserId = (int)HttpContext.Session.GetInt32("UserId");


            // Order NewOrder = new Order();
            User OrderedCart = _context.Users.Include(w => w.UserCart)
            .ThenInclude(w => w.CartItem)
            .FirstOrDefault(a=>a.UserId == LoggedInUserId);

            double Subtotal = 0;
            List<Product> OrderedProducts = new List<Product>();
            foreach(ShoppingCart p in OrderedCart.UserCart)
            {
                Subtotal = Subtotal + p.CartItem.Price;
                OrderedProducts.Add(p.CartItem);
            }

            NewOrder.TotalCost = Subtotal;
            NewOrder.Products = OrderedProducts;

            _context.Orders.Add(NewOrder);
            _context.SaveChanges();
            
            List<ShoppingCart> ClearCart = _context.ShoppingCarts.Where(a => a.UserId == LoggedInUserId).ToList();
            foreach(ShoppingCart s in ClearCart)
            {
                _context.ShoppingCarts.Remove(s);
                _context.SaveChanges();
            }
            return Redirect("/OrderPlaced");
        }

        [HttpGet("/OrderPlaced")]
        public IActionResult OrderPlaced()
        {
            return View();
        }












        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



