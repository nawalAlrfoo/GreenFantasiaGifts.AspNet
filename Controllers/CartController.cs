using GreenFantasiaGifts011.Data;
using GreenFantasiaGifts011.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GreenFantasiaGifts011.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = GetCartFromSession();
            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            var cart = GetCartFromSession();
            var item = cart.FirstOrDefault(c => c.ProductId == id);

            if (item == null)
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Quantity = 1
                });
            }
            else { item.Quantity++; }

            SaveCartToSession(cart);
            return RedirectToAction("Index");
        }

        public IActionResult IncreaseQuantity(int id)
        {
            var cart = GetCartFromSession();
            var item = cart.FirstOrDefault(c => c.ProductId == id);
            if (item != null) item.Quantity++;
            SaveCartToSession(cart);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseQuantity(int id)
        {
            var cart = GetCartFromSession();
            var item = cart.FirstOrDefault(c => c.ProductId == id);
            if (item != null)
            {
                if (item.Quantity > 1) item.Quantity--;
                else cart.Remove(item);
            }
            SaveCartToSession(cart);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItem(int id)
        {
            var cart = GetCartFromSession();
            var item = cart.FirstOrDefault(c => c.ProductId == id);
            if (item != null) cart.Remove(item);
            SaveCartToSession(cart);
            return RedirectToAction("Index");
        }

        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Checkout()
        {
            var cart = GetCartFromSession();
            if (cart.Count == 0) return RedirectToAction("Index");

            // نرسل المجموع الكلي ليظهر في صفحة الدفع
            ViewBag.CartTotal = cart.Sum(x => x.Total);
            return View();
        }

        // --- إضافة أكشن معالجة الطلب ---
        [Authorize]
        [HttpPost]
        public IActionResult PlaceOrder()
        {
            var cart = GetCartFromSession();
            if (cart.Count == 0) return RedirectToAction("Index");

            // 1. منطق حفظ الطلب في قاعدة البيانات يوضع هنا مستقبلاً

            // 2. تفريغ السلة بعد نجاح العملية
            HttpContext.Session.Remove("Cart");

            return RedirectToAction("OrderSuccess");
        }

        public IActionResult OrderSuccess()
        {
            return View();
        }

        // --- دالات مساعدة ---
        private List<CartItem> GetCartFromSession()
        {
            var data = HttpContext.Session.GetString("Cart");
            return data == null ? new List<CartItem>() : JsonSerializer.Deserialize<List<CartItem>>(data);
        }

        private void SaveCartToSession(List<CartItem> cart)
        {
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
        }
    }
}