using DatabaseDemo_EF;

//ProductContext productDb = new ProductContext();

//Product product = new Product { Name = "sample", Description = "sample", Price = 1000, CategoryId = 1 };
//productDb.Products.Add(product);
//int res = productDb.SaveChanges();
//Console.WriteLine(res > 0 ? "added" : "failed");

//var products = productDb.Products;
//products.ToList().ForEach(p => Console.WriteLine(p));
//productDb.Dispose();

//IDisposable => void Dispose();

using (ProductContext productDb = new())
{
    Product product = new Product { Name = "sample", Description = "sample", Price = 1000, CategoryId = 1 };
    productDb.Products.Add(product);
    int res = productDb.SaveChanges();
    Console.WriteLine(res > 0 ? "added" : "failed");

    var products = productDb.Products;
    products.ToList().ForEach(p => Console.WriteLine(p));
}

