using System;
namespace cart_service.Feature.Cart.Domain.Services
{
    public class ItemService : IItemService
    {
        public void AddItem(Item item, int number)
        {
            item.quantity += number;
        }
    }
}

