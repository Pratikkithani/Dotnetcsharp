namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region assignment_1
            //Console.WriteLine("Enter your salary:");
            //double salary = Convert.ToDouble(Console.ReadLine());
            //double basicSalary = salary;
            //Console.WriteLine("Enter your rating:");
            //int rating = Convert.ToInt32(Console.ReadLine());   

            //salary = salary - salary * 0.1;

            //if (rating >= 8)
            //{
            //    salary = salary + salary * 0.2;
            //}
            //else if (rating >= 5)
            //{
            //    salary = salary + salary * 0.1;
            //}

            //Console.WriteLine($"Salary of employee: {basicSalary} and the computed salary is {salary}");
            #endregion

            #region assignment_2
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

            #endregion

            #region assignment_3

            //   string[] username = { "Pratik", "Affan", "Sanchita" };
            //   double[] walletBalance = { 10000, 20000, 30000 };

            //returnto:
            //   Console.WriteLine("Enter the username:");
            //   string user_name = Console.ReadLine();
            //   bool isUserFound = false;

            //   for (int i = 0; i < username.Length; i++)
            //   {
            //       if (username[i] == user_name)
            //       {
            //           Console.WriteLine($"{user_name}, your wallet balance is {walletBalance[i]}");
            //           isUserFound=true;
            //           break;
            //       }
            //   }

            //   if (!isUserFound)
            //   {
            //       Console.WriteLine("No user found");
            //       goto returnto;
            //   }
            #endregion

        }
    }
}
