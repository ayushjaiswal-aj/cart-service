using System;
namespace cart_service.Feature.Cart.Domain
{
	public class Product
	{
		public String name { get; }
		public int price { get; }

		public Product(String name, int price)
		{
			this.name = name;
			this.price = price;
		}
	}
}

