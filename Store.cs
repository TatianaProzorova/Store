﻿using System;
using System.Collections.Generic;

namespace Store
{
    public class Store
    {
        public List<Product> Products;

        public List<Product> Basket;

        public List<Order> Orders;
        public Store()
        {
            Products = new List<Product>
            {
                new Product("Хлеб", 25),
                new Product("Молоко", 100),
                new Product("Печенье", 50),
                new Product("Масло", 250),
                new Product("Йогурт", 300),
                new Product("Сок", 80)
            };

            Basket = new List<Product>();
            Orders = new List<Order>();
        }

        public void ShowCatalog()
        {
            Console.WriteLine("Каталог продуктов");
            ShowProducts(Products);
        }

        public void ShowBasket()
        {
            Console.WriteLine("Содержимое корзины");
            ShowProducts(Basket);
        }

        public void AddToBasket(int numberProduct)
        {
            Basket.Add(Products[numberProduct - 1]);
            Console.WriteLine($"Продукт {Products[numberProduct - 1].Name} успешно добавлен в корзину.");
            Console.WriteLine($"В корзине {Basket.Count} продуктов.");
        }

        public void ShowProducts(List<Product> products)
        {
            int number = 1;
            foreach (Product product in products)
            {
                Console.Write(number + ". ");
                product.Print();
                number++;
            }
        }

        public void PutOrder()
        {
            Order order = new Order(Basket);
            Orders.Add(order);

            Basket.Clear();
        }
    }
}
