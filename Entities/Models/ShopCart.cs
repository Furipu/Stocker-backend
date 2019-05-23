using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class ShopCart
    {
        public int Id { get; set; }
        public int  Quantity { get; set; }
        public string AdditionalInfo { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
