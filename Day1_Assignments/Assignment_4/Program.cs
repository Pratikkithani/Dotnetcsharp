namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = null;
            Console.WriteLine("Enter the discharge date: ");
            date = Console.ReadLine();

            if (date == "")
            {
                Console.WriteLine("Not Discharged");
            }
            else
            {
                Console.WriteLine($"\nDischarge Date is : {date}");
            }
        }
    }
}
