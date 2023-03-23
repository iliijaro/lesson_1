﻿using System;
using HelloName_Lesson.ProductClasses;

namespace HelloName_Lesson.ProductClasses
{
    public class Beverages : Product
    {
        public Beverages(string productName, double productPrice, string produceDate, string expirationDate) : base(productName, productPrice, produceDate, expirationDate) { }

        public override void GetInfoProduct()
        {
            Console.WriteLine($"Product '{productName}' costs {productPrice}(BYN), produced on {produceDate} and expired on {expirationDate}\n");
        }

        public override bool CheckTheExpirationDate()
        {
            DateTime endDate = DateTime.Parse(expirationDate);
            if (endDate > currentDate)
            {
                return true;
            }
            return false;
        }
    }
}