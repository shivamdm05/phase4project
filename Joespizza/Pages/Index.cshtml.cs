using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Joespizza.Entities;
using Joespizza.Models;

namespace Joespizza.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Product> Products;

        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.findAll();
        }
    }
}