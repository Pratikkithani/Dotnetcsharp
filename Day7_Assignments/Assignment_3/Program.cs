using Assignment_3.Model;

namespace Assignment_3
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

            var result1 = products.MaxBy(p => p.Price);

            Console.WriteLine($"Highest is :: {result1.Name}");

        }
    }
}
