﻿namespace DesignPattern.Facade.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAdress { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
    }
}
