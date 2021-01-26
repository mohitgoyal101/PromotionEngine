using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class SKU
    {
        public string Id { get; set; }
    }

    public class CartSKU : SKU
    {
        public int Quantity { get; set; }

        public double DiscountedPrice { get; set; }

        public bool IsPromotionApplied { get; set; }
    }
}
