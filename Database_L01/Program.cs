// See https://aka.ms/new-console-template for more information

using Database_L01;
using SQLitePCL;
using static System.Net.Mime.MediaTypeNames;
AppDbContext db = new AppDbContext();
db.Database.EnsureCreated();
//Product product = new Product() { Name = "Laptop", Quantity = 10, Price = 1000 };
//Product product2 = new Product() { Name = "Mouse", Quantity = 100, Price = 10 };
//Product product3= new Product() { Name = "Keyboard", Quantity = 100, Price = 10 };

//db.Products.Add(product);
//db.Products.Add(product2);
//db.Products.Add(product3);
//db.SaveChanges();
//db.Products.ToList();
//List<Product> products = db.Products.ToList();
//var products = db.Products.ToList().Where(p => p.Price >= 100).Sum(p => p.Price);
//Console.WriteLine(products);
////var x = 10.0m;//if you make a double change the m
//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Name} {product.Quantity} {product.Price}");
//}
