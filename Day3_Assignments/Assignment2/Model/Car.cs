using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Model
{
    public class Car
    {
        private int carID;
        private string brand;
        private string model;
        private int year;
        private double price;

        public int CarID
        {
            get { return carID; }
            set { carID = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(int carID, string brand, string model, int year, double price)
        {
            Console.WriteLine("Receiving Car Information");
            this.carID = carID;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Car()
        {
            Console.WriteLine("Receiving Default Car Information");
            carID = 0;
            brand = "Unknown";
            model = "Unknown";
            year = 2000;
            price = 0.0;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine("Presenting Car Information");
            Console.WriteLine($"Car ID: {CarID}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
