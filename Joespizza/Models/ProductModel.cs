using Joespizza.Entities;

namespace Joespizza.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Id = "01",
                    Name = "Margherita",
                    Price =345,
                    Photo = "Margherita.jpg"
                },

                new Product
                {
                    Id = "02",
                    Name = "Veggie Paradise",
                    Price =445,
                    Photo = "veggie.jpeg"
                },
                new Product
                {
                    Id = "03",
                    Name = "Peri Peri Paneer",
                    Price =445,
                    Photo = "peri.jfif"
                },
                new Product
                {
                    Id = "04",
                    Name = "Chicken Tikka",
                    Price =495,
                    Photo = "tikka.jpg"
                },
                new Product
                {
                    Id = "05",
                    Name = "Tandoori Chicken",
                    Price =495,
                    Photo = "tandoori.jpg"
                },
                new Product
                {
                    Id = "06",
                    Name = "Mexicano Delight",
                    Price =495,
                    Photo = "mexican.jpeg"
                }
            };
        }
        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            //return Products.Where(p => p.Id == id).FirstOrDefault();
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
