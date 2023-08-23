﻿namespace DesignPattern.Observer.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool DiscountCodeStatus { get; set; }
    }
}
