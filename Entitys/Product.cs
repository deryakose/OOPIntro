using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountedPrice { get; }
    }
}
