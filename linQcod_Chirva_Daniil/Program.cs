using System;
using System.Collections.Generic;
public class Product
{
public int Id { get; set; }
public string Name { get; set; }
public string Category { get; set; }
public double Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
{
new Product { Id = 1, Name = "Ноутбук", Category = "Електроніка", Price = 1200 },
new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
new Product { Id = 4, Name = "Смартфон", Category = "Електроніка", Price = 800 },
new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
new Product { Id = 7, Name = "Телевізор", Category = "Електроніка", Price = 1500 },
new Product { Id = 8, Name = "Кросівки", Category = "Взуття", Price = 80 },
new Product { Id = 9, Name = "Піча", Category = "Їжа", Price = 10 },
new Product { Id = 10, Name = "Монітор", Category = "Електроніка", Price = 300 },
new Product { Id = 11, Name = "Світшот", Category = "Одяг", Price = 35 },
new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
new Product { Id = 14, Name = "Чайник", Category = "Побутова техніка", Price = 40 },
new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
new Product { Id = 16, Name = "Мишка", Category = "Електроніка", Price = 10 },
new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
new Product { Id = 19, Name = "Кавоварка", Category = "Побутова техніка", Price = 60 },
new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
};
        var electronicProducts = products.Where(p => p.Category == "Електроніка"); // Вибрати всі товари з категорії "Електроніка".


        foreach (var product in electronicProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        var mostdorogoyProduct = products.OrderByDescending(p => p.Price).FirstOrDefault(); // Знайти найдорожчий товар


        if (mostdorogoyProduct != null)
        {
            Console.WriteLine($"Найдорожчий товар: {mostdorogoyProduct.Name}, Ціна: {mostdorogoyProduct.Price}");
        }
        else
        {
            Console.WriteLine("Список продуктів порожній.");
        }

        double totaliqCostic = products.Sum(p => p.Price); // Підрахувати загальну вартість всіх товарів


        Console.WriteLine($"Загальна вартість всіх товарів: {totaliqCostic}");

        var sortedProducti = products.OrderBy(p => p.Price); // Відсортувати товари за ціною у зростаючому порядку


        foreach (var product in sortedProducti)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}");
        }

        
        var uniquyyCategories = products.GroupBy(p => p.Category) // Вибір унікальних категорій
                                       .Where(g => g.Count() == 1)
                                       .Select(g => g.Key);


        foreach (var category in uniquyyCategories)
        {
            Console.WriteLine(category);
        }

        var categoryCounts = products.GroupBy(p => p.Category) // Знайти кількість товарів у кожній категорії.
                                     .Select(g => new { Category = g.Key, Count = g.Count() });

        
        foreach (var item in categoryCounts)
        {
            Console.WriteLine($"Категорія: {item.Category}, Кількість товарів: {item.Count}");
        }

        var productsStartingWithSSSSSSSS = products.Where(p => p.Name.StartsWith("С")); // Вибрати товари з назвами, які починаються на букву "С".

        foreach (var product in productsStartingWithSSSSSSSS)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        
        double averagePrice = products.Average(p => p.Price); // Знаходження середньої ціни товарів

        
        Console.WriteLine($"Середня ціна товарів: {averagePrice}");

        
        var cheapProducts = products.Where(p => p.Price < 50); // Вибір товарів з ціною менше 50



        foreach (var product in cheapProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        
        int countExpensiveProducts = products.Count(p => p.Price > 100); // // Підрахунок кількості товарів з ціною більше 100

        
        Console.WriteLine($"Кількість товарів з ціною більше 100: {countExpensiveProducts}");

        
        var first5Products = products.Take(5); // Вибір перших 5 товарів

        
        foreach (var product in first5Products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        
        Product lastProduct = products.Last(); // Отримання останнього товару

        
        Console.WriteLine($"Id: {lastProduct.Id}, Name: {lastProduct.Name}, Category: {lastProduct.Category}, Price: {lastProduct.Price}");

        
        var fude = products.Where(p => p.Category == "Їжа").OrderBy(p => p.Price); // Вибір та сортування товарів з категорії "Їжа" за зростанням ціни


        foreach (var product in fude)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }


        var CAPS = products.Select(p => p.Name.ToUpper()); // Повернення імен товарів в верхньому регістрі


        foreach (var name in CAPS)
        {
            Console.WriteLine(name);
        }

        
        var productsInRange = products.Where(p => p.Price >= 10 && p.Price <= 100); // Вибір товарів, ціна яких лежить у діапазоні від 10 до 100


        foreach (var product in productsInRange)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        
        double minPrice = products.Min(p => p.Price); // Знаходження найменшої ціни серед товарів

        Console.WriteLine($"Найменша ціна серед товарів: {minPrice}");

        
        var coffeeProducts = products.Where(p => p.Name.Contains("Кава")); // Вибір товарів, що містять слово "Кава" в назві


        foreach (var product in coffeeProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }

        
        int totalICount = products.Count(); // Підрахунок загальної кількості товарів


        Console.WriteLine($"Загальна кількість товарів: {totalICount}");


        
        var productWithMinId = products.OrderBy(p => p.Id).First(); // Знайти товар з найменшим ідентифікатором

        
        Console.WriteLine($"Товар з найменшим ідентифікатором: Id={productWithMinId.Id}, Name={productWithMinId.Name}, Category={productWithMinId.Category}, Price={productWithMinId.Price}");

        
        var productsWithSingleWordName = products.Where(p => !p.Name.Contains(" ")); // Вибір товарів, назви яких містять лише одне слово


        foreach (var product in productsWithSingleWordName)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
        }
    }
}






