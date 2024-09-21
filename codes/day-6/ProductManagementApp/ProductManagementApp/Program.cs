using ProductManagementApp;

List<Product> products = [
    new Product { Id = 2, Name = "dell laptop", Description = "new laptop from dell", Price = 120000 },
    new Product { Id = 1, Name = "lenovo laptop", Description = "new laptop from lenovo", Price = 100000 },
    new Product { Id = 3, Name = "apple mac", Description = "new laptop from apple", Price = 160000 }
    ];

//Task-1:
//filter the products with price more than XXXX
FilterProducts(products);
static void FilterProducts(List<Product> products)
{
    products
        .Where(p => p.Price > 110000)
        .ToList()
        .ForEach(p => Console.WriteLine(p));
}

//Task-2: sorting
//sorting choices
//1. sort by id
//2. sort by name
//3. sort by price

//ask user for choice to sort 
//sort the products based on that
PrintMenu();
int choice = GetChoice();
List<Product> result = SortProducts(products, choice);
result.ForEach(p => Console.WriteLine(p));

static void PrintMenu()
{
    Console.WriteLine("1. sort by id\n2. sort by name\n3. sort by price");
}

static int GetChoice()
{
    Console.Write("\nEnter Choice[1/2/3]: ");
    int choice = int.Parse(Console.ReadLine() ?? "1");
    return choice;
}

static List<Product> SortProducts(List<Product> products, int choice)
{
    List<Product> result;
    switch (choice)
    {
        case 1:
            result = products.OrderBy(p => p.Id).ToList();
            break;

        case 2:
            result = products.OrderBy(p => p.Name).ToList();
            break;

        case 3:
            result = products.OrderBy(p => p.Price).ToList();
            break;

        default:
            result = products.OrderBy(p => p.Id).ToList();
            break;
    }
    return result;

    //or (switch expression)
    //return choice switch
    //{
    //    1 => products.OrderBy(p => p.Id).ToList(),
    //    2 => products.OrderBy(p => p.Name).ToList(),
    //    3 => products.OrderBy(p => p.Price).ToList(),
    //    _ => products.OrderBy(p => p.Id).ToList(),
    //};

    //or (switch expression with collection initializer expression)
    //return choice switch
    //{
    //    1 => [.. products.OrderBy(p => p.Id)],
    //    2 => [.. products.OrderBy(p => p.Name)],
    //    3 => [.. products.OrderBy(p => p.Price)],
    //    _ => [.. products.OrderBy(p => p.Id)],
    //};
}