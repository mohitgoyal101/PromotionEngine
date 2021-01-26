using PromotionEngine.Interfaces;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionEngine : IPromotionEngine
    {
        private Dictionary<SKU, double> _priceList { get; set; }

        public PromotionEngine(Dictionary<SKU, double> priceList)
        {
            _priceList = priceList;
        }

        public double ApplyPromotion(Cart cart)
        {
            double total = 0;
           
            //Calculate Actual Price For Items 
            foreach (CartSKU cartSKU in cart.CartSKUs.Where(x => x.IsPromotionApplied == false))
            {
                total = total + GetPrice(cartSKU, _priceList);
            }

            return total;
        }

        private double GetPrice(CartSKU cartSKU, Dictionary<SKU, double> priceList)
        {
            double unitPrice = priceList[priceList.Keys.FirstOrDefault(x => x.Id == cartSKU.Id)];
            return cartSKU.Quantity * unitPrice;
        }
    }
}
