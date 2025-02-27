using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class Info
    {
        public int carID;
        public string brand;
        public string model;
        public int year;
        public double price;

        public void AcceptCarDetails()
        {
            Console.WriteLine("Receiving Car Information");

            Console.Write("Enter Car ID: ");
            carID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Brand: ");
            brand = Console.ReadLine();

            Console.Write("Enter Model: ");
            model = Console.ReadLine();

            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine("Presenting Car Information");
            Console.WriteLine($"Car ID: {carID}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: ${price}");
        }
    }
}
