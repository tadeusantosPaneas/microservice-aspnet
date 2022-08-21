﻿namespace Basket.API.Entities;

public class ShoppingCart
{
    public string? UserName { get; set; }
    public List<ShoppingCartItem> Items { get; set; }

    public ShoppingCart()
    {
        Items ??= new List<ShoppingCartItem>();
    }
    public ShoppingCart(string userName)
    {
        Items ??= new List<ShoppingCartItem>();
        UserName = userName;
    }

    public decimal TotalPrice
    {
        get
        {
            decimal totalprice = 0;            
            foreach (var item in Items)
            {
                totalprice += item.Price * item.Quantity;
            }
            return totalprice;
        }
    }


}
