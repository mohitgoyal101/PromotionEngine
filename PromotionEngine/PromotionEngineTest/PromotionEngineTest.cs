﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Model;

namespace PromotionEngineTest
{
    [TestClass]
    public class PromotionEngineTest
    {
        Dictionary<SKU, double> priceList = null;

        [TestInitialize]
        public void Init()
        {
            //This should come from backend. For now initialising here for running test cases
            priceList = new Dictionary<SKU, double>();
            priceList.Add(new SKU() { Id = "A" }, 50);
            priceList.Add(new SKU() { Id = "B" }, 30);
            priceList.Add(new SKU() { Id = "C" }, 20);
            priceList.Add(new SKU() { Id = "D" }, 15);
        }

        [TestCleanup]
        public void TestClean()
        {
        }

        [TestMethod]
        public void Scenario1_ApplyPromotion_ReturnTotal()
        {
            //Prepare
            Cart cart = new Cart()
            {
                CartSKUs = new List<CartSKU>()
                {
                    new CartSKU()
                    {
                        Id="A",
                        Quantity=1
                    },
                     new CartSKU()
                    {
                        Id="B",
                        Quantity=1
                    },
                      new CartSKU()
                    {
                        Id="C",
                        Quantity=1
                    },
                }
            };

            //Act

            //Assert
        }
    }
}
