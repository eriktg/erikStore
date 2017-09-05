using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using erikStore.Models;

namespace erikStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}