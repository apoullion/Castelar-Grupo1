﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Shop_Data.Model
{
    public class CartItem : Identity
    {

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public CartItem()
        {

        }

        public CartItem(int id, int CartId, int ProductId, float Price, int Quantity, DateTime CreatedOn, String CreatedBy, DateTime ChangedOn, String ChangedBy)
        {

            this.Id = id;
            this.CartId = CartId;
            this.ProductId = ProductId;
            this.Price = Price;
            this.Quantity = Quantity;
            this.CreateOn = CreateOn;
            this.CreatedBy = CreatedBy;
            this.ChangedOn = ChangedOn;
            this.ChangedBy = ChangedBy;
        }
    }
}
