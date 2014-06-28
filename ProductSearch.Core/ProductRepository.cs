using System;
using System.Threading.Tasks;
using System.Linq;

namespace ProductSearch.Core
{
	public class ProductRepository
	{
		private Product[] products = new [] {
			new Product { Id = 1, Name = "Shoes", Price = 19.99f },
			new Product { Id = 2, Name = "Shirt", Price = 15.99f },
			new Product { Id = 3, Name = "Hat", Price = 9.99f }
		};

		public async Task<Product[]> SearchProducts(string searchTerm){
			await Task.Delay (2000); // simulate latency for web request

			searchTerm = searchTerm.ToLower ();
			return products.Where (p => p.Name.ToLower().Contains(searchTerm)).ToArray();
		}
	}
}

