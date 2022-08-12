using OOP1;

Product product1 = new Product { Id=1, CategoryId=2, ProductName="Table", UnitInStock=5, UnitPrice=15};
Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Pencil", UnitInStock = 7, UnitPrice = 21};

ProductManager productManager = new ProductManager();
productManager.Add(product1);

Console.WriteLine(product1.ProductName);