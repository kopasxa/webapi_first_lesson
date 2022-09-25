using Microsoft.AspNetCore.Mvc;

namespace Web_app_first.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller {
        public static List<Product> products = new List<Product> {
            new Product {
                id = 2,
                price = 20.0f,
                name = "Milk",
                productionDate = new DateTime(2021, 1, 1)
            },
            new Product {
                id = 3,
                price = 10.0f,
                name = "Bread",
                productionDate = new DateTime(2021, 1, 1)
            },
            new Product {
                id = 3,
                price = 30.0f,
                name = "Eggs",
                productionDate = new DateTime(2021, 1, 1)
            }
        };
        [HttpGet("{id}")]
        public IEnumerable<Product> Get(int id) {
            return products.Where(product => product.id == id).ToArray();
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get() {
            return products;
        }
    }
}
