using PoilicyHackathon.Constants;
using PoilicyHackathon.Model;
using PoilicyHackathon.Repository;

namespace PoilicyHackathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int next = 0;
            IPolicyRepository ipr = new PolicyRepository();
            int choice;

            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Add\n2. View All\n3. Search\n4. Update\n5. Delete\n6. Active Policies\n7. Exit");
                Console.WriteLine("---------------------");
                Console.WriteLine("Enter the choice :: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        next++;
                        Console.WriteLine("Enter the Name::");
                        string name = Console.ReadLine();
                        DateTime start = DateTime.Now;
                        Console.WriteLine($"Start Date is {start}");
                        Console.WriteLine("Enter End Date (yyyy-MM-dd): ");
                        DateTime end = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Policy type");
                        Console.WriteLine("1. Life\n2. Health\n3. Vehicle\n4. Property");
                        Console.WriteLine("Enter which you want::");
                        PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType),Console.ReadLine());
                        ipr.AddPolicy(new Poilcy(next, name, type, start, end));
                        Console.WriteLine();
                        Console.WriteLine("Successfully Added");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        ipr.ViewAllPolicies();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter the valid id::");
                        int search = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        ipr.SearchPolicyById(search);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Enter the id::");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name::");
                        name = Console.ReadLine();
                        start = DateTime.Now;
                        Console.WriteLine($"Start Date is {start}");
                        Console.WriteLine("Enter End Date (yyyy-MM-dd): ");
                        end = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Policy type");
                        Console.WriteLine("1. Life\n2. Health\n3. Vehicle\n4. Property");
                        Console.WriteLine("Enter which you want::");
                        type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());
                        ipr.UpdatePolicy(new Poilcy(id, name, type, start, end));
                        Console.WriteLine();
                        Console.WriteLine("Updated Successfully");
                        Console.WriteLine();

                        break;

                    case 5:
                        Console.WriteLine("Enter the valid Id::");
                        search = Convert.ToInt32(Console.ReadLine());
                        ipr.DeletePolicy(search);
                        Console.WriteLine();
                        Console.WriteLine("Deleted Successfully");
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine();
                        ipr.ActivePolicies();
                        Console.WriteLine();
                        break;
                    
                    case 7:
                        return;

                    default:
                        Console.WriteLine("Please enter the valid choice");
                        break;
                }
            } 
        }
    }
}
