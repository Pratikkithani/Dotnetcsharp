namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double totalAmount = 0;
            do
            {
                Console.WriteLine("1.General\n2.AC\n3.Sleeper\n4.Exit");
                Console.WriteLine("Enter the choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the no. of tickets you want of General:");
                        int totalGeneralTicket = Convert.ToInt32(Console.ReadLine());
                        totalAmount = totalAmount + totalGeneralTicket * 200;
                        break;
                    case 2:
                        Console.WriteLine("Enter the no. of tickets you want of General:");
                        int totalAcTicket = Convert.ToInt32(Console.ReadLine());
                        totalAmount = totalAmount + totalAcTicket * 1000;
                        break;
                    case 3:
                        Console.WriteLine("Enter the no. of tickets you want of General:");
                        int totalSleeperTicket = Convert.ToInt32(Console.ReadLine());
                        totalAmount = totalAmount + totalSleeperTicket * 500;
                        break;
                    case 4:
                        Console.WriteLine("Thanks for booking");
                        Console.WriteLine($"Your Total cost is {totalAmount}");
                        break;
                    default:
                        Console.WriteLine("enter valid choice");
                        break;

                }
            } while (choice != 4);
        }
    }
}
