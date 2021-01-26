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
        private IPromotionStrategy _promotionStrategy = null;
        private List<Promotion> lstActivePromotions = null;

        public PromotionEngine(Dictionary<SKU, double> priceList, IPromotionStrategy promotionStrategy)
        {
            _priceList = priceList;
            this._promotionStrategy = promotionStrategy;
        }

        public double ApplyPromotion(Cart cart)
        {
            double total = 0;
            lstActivePromotions = this._promotionStrategy.GetActivePromotion();
            foreach (var availablePromotion in lstActivePromotions)
            {
                total = total + availablePromotion.CalculatePrice(cart.CartSKUs, _priceList);
            }

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
