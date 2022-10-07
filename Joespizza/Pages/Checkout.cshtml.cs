using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Joespizza.Entities;
using Joespizza.Helpers;
using Joespizza.Models;

namespace Joespizza.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly ILogger<CheckoutModel> _logger;

        public CheckoutModel(ILogger<CheckoutModel> logger)
        {
            _logger = logger;
        }
        //public double checkout { get; set; }

        //public double Total { get; set; }


        public List<Item> cart { get; set; }
        public double Total { get; set; }

        //(HttpContext.Session, "Checkout");
        public void OnGet()
        {
            //checkout = SessionHelper.GetObjectFromJson<double>(HttpContext.Session, "checkout");

            //Total = checkout.Sum(i => i.Product.Price * i.Quantity);
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.Price * i.Quantity);
            }
            else
            {
                Total = 0;
            }

        }
    }
}
