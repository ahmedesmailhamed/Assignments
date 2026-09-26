namespace Adv_2;
using System.Collections.Generic;

class Program
{
    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (filter(product))
                result.Add(product);
        }

        return result;
    }

    static void Main()
    {
        List<Product> catalog = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
        };

        var electronics = SearchProducts(catalog,
            p => p.Category == "Electronics");

        var cheaperThan50 = SearchProducts(catalog,
            p => p.Price < 50);

        var inStock = SearchProducts(catalog,
            p => p.Stock > 0);

        var clothingUnder100 = SearchProducts(catalog,
            p => p.Category == "Clothing" && p.Price < 100);

        Console.WriteLine("Electronics:");
        foreach (Product product in electronics)
            Console.WriteLine(product.Name);

        Console.WriteLine("\nProducts cheaper than $50:");
        foreach (Product product in cheaperThan50)
            Console.WriteLine(product.Name);

        Console.WriteLine("\nProducts in stock:");
        foreach (Product product in inStock)
            Console.WriteLine(product.Name);

        Console.WriteLine("\nClothing under $100:");
        foreach (Product product in clothingUnder100)
            Console.WriteLine(product.Name);
    }
}