using System.Diagnostics;
using System.Reflection;
using Assignment2.Model;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Receiving Car Information");

            //Console.Write("Enter Car ID: ");
            //int carID = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Brand: ");
            //string brand = Console.ReadLine();

            //Console.Write("Enter Model: ");
            //string model = Console.ReadLine();

            //Console.Write("Enter Year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Price: ");
            //double price = Convert.ToDouble(Console.ReadLine());

            Car  car1 = new Car(1,"Toyota","Fortuner",2002,2000);
            car1.DisplayCarDetails();


            Car car2 = new Car();
            car2.DisplayCarDetails();

        }
    }
}
