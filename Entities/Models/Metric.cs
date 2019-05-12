using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Metric
    {
        public int Id { get; set; }
        public string MetricName { get; set; }
        //public int Piece { get; set; }
        //public decimal Liter { get; set; }
        //public decimal DeciLiter { get; set; }
        //public decimal MiliLiter { get; set; }
        //public decimal HectoLiter { get; set; }
        //public decimal Kilo { get; set; }
        //public decimal gram { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductVersion> ProductVersions { get; set; }
    }
}
