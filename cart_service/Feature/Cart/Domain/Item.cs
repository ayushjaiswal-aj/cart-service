using System;
namespace cart_service.Feature.Cart.Domain
{
	public class Item
	{
		public Product product { get; set; }
		public int quantity { get; set; }

		public Item(Product product, int quantity)
		{
			this.product = product;
			this.quantity = quantity;
		}
	}
}

