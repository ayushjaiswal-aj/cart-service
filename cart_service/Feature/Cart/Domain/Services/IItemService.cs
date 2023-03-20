using System;
namespace cart_service.Feature.Cart.Domain.Services
{
	public interface IItemService
	{
        public void increaseQuantity(Item item, int number);
    }
}
