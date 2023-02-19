using DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new UdemyEFCoreDBFirstContext())
{
    var products = await context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine(value: $"{p.Id}: {p.Name} {p.Stock} {p.Price}");
    });
}