using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreFront.Data.EF; //Added for access to Entity Models (Books)
using System.ComponentModel.DataAnnotations; //Added for access to validation/display metadata attributes

namespace StoreFront.UI.MVC.Models
{
    //Added this model to combine Domain/Entity-related info (Book) with 
    //other info -- Therefore, it's a ViewModel
    public class CartItemViewModel
    {
        [Range(1, int.MaxValue)]
        public int Qty { get; set; }

        public Product Product { get; set; }


        public CartItemViewModel(int qty, Product product)
        {
            Qty = qty;
            Product = product;
        }

    }
}