A shopping cart package that facilitates 2 basic capabilities.

1. Add multiple products to the cart. A product has a name and price. You should be able to specify how many of each product is being added to the cart, and provide a means to observe the resulting state.

2. Calculate the totals:
   1. Cart subtotal (sum of price for all items)
   2. Tax payable (charged at 12.5% on the subtotal)
   3. Total payable (subtotal + tax)
   

```
  Add 1 × cornflakes @2.52 each
  Add another 1 x cornflakes @2.52 each
  Add 1 × weetabix @9.98 each
  
  Then: 
  
  Cart contains 2 x conflakes
  Cart contains 1 x weetabix
  Subtotal = 15.02
  Tax = 1.88
  Total = 16.90
```

## Assumptions
1. Assumes USD as default currency 
2. Assumes product name is unique
