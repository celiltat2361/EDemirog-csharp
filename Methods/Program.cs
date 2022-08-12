using Methods;

//Product product1 = new Product(1, "Apple", 15, "Amasya Apple");

Product product1 = new Product();
product1.Name = "Apple";
product1.Description = "Amasya Apple";
product1.Id = 1;
product1.Price = 15;

Product product2 = new Product();
product2.Name = "Orange";
product2.Description = "Blood Orange";
product2.Id = 2;
product2.Price = 25;

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name + ": " + product.Price);
}

Console.WriteLine("------------------Metods-----------------------");

//instance--örnek olustur
CartManager cartManager = new CartManager();
cartManager.Add(product2);