using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

Initializer.Build();
using (var _context = new AppDbContext())
{
    try
    {
        var category = new Category() { Name = "Silgi" };

        category.Products.Add(new() { Name = "Silgi 1", Price = 50, Stock = 200, Barcode = "200", ProductFeature = new() { Color = "Red", Width = 30, Height = 30 } });
        category.Products.Add(new() { Name = "Silgi 2", Price = 75, Stock = 200, Barcode = "201" });


        _context.Add(category);
        _context.SaveChanges();
        Console.WriteLine("Kayıt Başarılı");
    }
    catch (Exception ex)
    {
        throw new Exception();
    }
}