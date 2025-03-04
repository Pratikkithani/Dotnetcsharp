using Assignment_2.Model;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductID=1,Name="HeadPhone",Category="Electronics",Price=2000},
                new Product{ProductID=2,Name="Toy",Category="Gaming",Price=500},
                new Product{ProductID=3,Name="Laptop",Category="Electronics",Price=5000}
            };

            var result = 
                         from product in products
                         where product.Price>1000 
                         group product by product.Category into g
                         select g;

            foreach (var prod in result)
            {
                Console.WriteLine($"Category of {prod.Key} which is greater than 1000 is ::");
                if(prod.Key == "Electronics")
                foreach (var item in prod)
                {
                    Console.WriteLine($"Name:: {item.Name}");
                }

            }

        }
    }
}
