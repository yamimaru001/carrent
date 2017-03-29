﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
  
    public partial class Products
    {
        
        public class Product
        {
            
            public int ProductId { get; set; }
            
            public string Name { get; set; }
            
            public string CategoryName { get; set; }
           
            public int Price { get; set; }
        }


        private static readonly Products _instance = new Products();

        private Products() { }

        public static Products Instance
        {
            get { return _instance; }
        }
        public List<Product> ProductList
        {
            get { return products; }
        }
        private List<Product> products = new List<Product>() 
        { 
                new Product() { ProductId = 1, Name = "Product 1", CategoryName = "Category 1", Price=10}, 
                new Product() { ProductId = 1, Name = "Product 2", CategoryName = "Category 2", Price=5}, 
                new Product() { ProductId = 1, Name = "Product 3", CategoryName = "Category 3", Price=15}, 
                new Product() { ProductId = 1, Name = "Product 4", CategoryName = "Category 1", Price=9} 
        };
    }

}