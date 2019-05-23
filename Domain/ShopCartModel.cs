using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit;

namespace Domain
{
    public class ShopCartModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }
        public string AdditionalInfo { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
