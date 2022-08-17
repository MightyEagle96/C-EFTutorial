using EFrefresher.Data;
using EFrefresher.Models;

using JfoodContext context = new JfoodContext();

//to write to the database
//Product product = new Product() { Name = "Vanilla Ice Cream", Price = 10.10M };
//context.Products.Add(product);


 //Product product2 = new Product() { Name = "GOlden Morn", Price = 45.44M };
 //context.Add(product2);
 
 //context.SaveChanges();

//to read from the database
//var products = context.Products.Where(p=>p.Price >10).OrderBy(p=>p.Name);

//foreach (Product p in products)
//{
//    Console.WriteLine($"Id: {p.Id} | Name: {p.Name} | Price: {p.Price} ");
//    Console.WriteLine(new String('-', 20));
//}

////to update the record
//var okpa = context.Products.Where(p => p.Name == "Okpa").FirstOrDefault();

//if(okpa is Product)
//{
//    okpa.Name = "Okpa Di Okwu";
//}
//context.SaveChanges();

//Console.WriteLine("Product updated successfully");

//to delete a record
var product = context.Products.Where(c=>c.Id==2).FirstOrDefault();

if(product is not null)
{
    context.Remove(product);
    Console.WriteLine($"{product.Name} has been removed");
}
context.SaveChanges();

