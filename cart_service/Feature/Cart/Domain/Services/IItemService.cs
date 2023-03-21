using System;
namespace cart_service.Feature.Cart.Domain.Services
{
	public interface IItemService
	{
        public void AddItem(Item item, int number);
    }
}
