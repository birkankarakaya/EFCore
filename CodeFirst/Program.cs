using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

Initializer.Build();
using (var _context = new AppDbContext())
{
    //var category = new Category() { Name = "Silgi" };

    //category.Products.Add(new() { Name = "Silgi 1", Price = 50, Stock = 200, Barcode = "200", ProductFeature = new() { Color = "Red", Width = 30, Height = 30 } });
    //category.Products.Add(new() { Name = "Silgi 2", Price = 75, Stock = 200, Barcode = "201" });


    //await _context.AddAsync(category);
    //await _context.SaveChangesAsync();
    //Console.WriteLine("Kayıt Başarılı");



    var products = await _context.Products.ToListAsync();
    //var count = await _context.Products.CountAsync();    
    foreach (var product in products)
    {
        Console.WriteLine(product.Name);
    }
}