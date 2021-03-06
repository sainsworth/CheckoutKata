﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Models.Contract
{
    public interface IPriceList
    {
        bool HasItem(string sku);
        //ShopItem LookupItem(string sku);
        int GetItemsPrice(string sku, int quantity);
        void UpsertItem(string sku, int price);
        void UpsertItem(string sku, int price, int discountFor, int discount);
    }
}
