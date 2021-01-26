﻿using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    public interface IPromotionEngine
    {
        double ApplyPromotion(Cart cart);
    }
}
