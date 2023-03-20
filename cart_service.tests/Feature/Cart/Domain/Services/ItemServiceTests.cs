﻿using System;
using cart_service.Feature.Cart.Domain;
using cart_service.Feature.Cart.Domain.Services;

namespace cart_service.tests.Feature.Cart.Domain.Services
{
	public class ItemServiceTests
	{
		private IItemService _itemService;

		[SetUp]
		public void SetUp()
		{
			_itemService = new ItemService();
		}

		[Test]
		public void IncreaseQuantity_NumberIs1_IncreaseTheQuantityBy1()
		{
			Product cornflex = new Product("cornflex", 2);
			Item item = new Item(cornflex, 1);

			_itemService.increaseQuantity(item, 1);

			Assert.That(item.quantity, Is.EqualTo(2));
		}
	}
}

