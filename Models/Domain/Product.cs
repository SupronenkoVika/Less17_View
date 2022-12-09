﻿namespace Less17_View.Models.Domain
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductsType Type { get; set; }
        public Product() { }
        public Product(int id, string name, decimal price, ProductsType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
