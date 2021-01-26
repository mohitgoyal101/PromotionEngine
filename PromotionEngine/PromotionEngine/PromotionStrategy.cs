using PromotionEngine.Enums;
using PromotionEngine.Interfaces;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionStrategy : IPromotionStrategy
    {
        public PromotionStrategy()
        {
        }

        public List<Promotion> GetActivePromotion()
        {
            //This should come from backend. Hardcoding as of now
            List<Promotion> promotions = new List<Promotion>();

            Promotion bulkPromotionA = new BulkPromotion()
            {
                PromotionType = PromotionType.Bulk,
                SKU = new SKU()
                {
                    Id = "A"
                },
                ApplicablePrice = 130,
                MinQuantity = 3
            };
            promotions.Add(bulkPromotionA);

            Promotion bulkPromotionB = new BulkPromotion()
            {
                PromotionType = PromotionType.Bulk,
                SKU = new SKU()
                {
                    Id = "B"
                },
                ApplicablePrice = 45,
                MinQuantity = 2
            };
            promotions.Add(bulkPromotionB);
            
            return promotions;
        }
    }
}
