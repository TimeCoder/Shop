using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Domain.Services;

namespace WebUI.Controllers
{
    public class CartController : Controller
    {
		private ICartService _cartService;

		public CartController(ICartService cartService)
		{
			_cartService = cartService;
		}

        // GET: Cart
        public ActionResult Index()
        {
            return View(_cartService.Get());
        }

		//[HttpPost]
		public ActionResult Add(int productId, string returnUrl)
		{
			var cart = _cartService.Get();

			cart.AddLine(product, 1);

			_cartService.Update(cart);

			return View("Index");
		}
    }
}