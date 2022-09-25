using Microsoft.AspNetCore.Mvc;

namespace Web_app_first.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class SortedProductController {
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
            id = 1,
            price = 30.0f,
            name = "Eggs",
            productionDate = new DateTime(2021, 1, 1)
        }
    };
        [HttpGet(Name = "GetSortedProducts")]

        public IEnumerable<Product> Get() {
            return products.OrderBy(product => product.price).ToArray();
        }
    }
}
