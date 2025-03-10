using Hackathon_DB.Constant;
using Hackathon_DB.Model;
using Hackathon_DB.Repository;

namespace Hackathon_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPolicyRepository ipr = new PolicyRepository();
            int choice;

            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Add\n2. View All\n3. Update\n4. Delete\n5. Exit");
                Console.WriteLine("---------------------");
                Console.WriteLine("Enter the choice :: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Name::");
                        string name = Console.ReadLine();
                        DateTime start = DateTime.Now.Date;
                        Console.WriteLine($"Start Date is {start}");
                        Console.WriteLine("Enter End Date (yyyy-MM-dd): ");
                        DateTime end = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Policy type");
                        Console.WriteLine("1. Life\n2. Health\n3. Vehicle\n4. Property");
                        Console.WriteLine("Enter which you want::");
                        PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());
                        ipr.AddPolicy(new Policy()
                        {
                            PolicyHolderName=name,
                            PolicyType=type,
                            StartDate=start,
                            EndDate=end
                        });
                        Console.WriteLine();
                        Console.WriteLine("Successfully Added");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        List<Policy> allpolicies = ipr.ViewAllPolicies();
                        foreach(Policy policy in allpolicies)
                        {
                            Console.WriteLine(policy);
                        }
                        Console.WriteLine();
                        break;

                    //case 3:
                    //    Console.WriteLine("Enter the valid id::");
                    //    int search = Convert.ToInt32(Console.ReadLine());
                    //    Console.WriteLine();
                    //    ipr.SearchPolicyById(search);
                    //    Console.WriteLine();
                    //    break;

                    case 3:
                        Console.WriteLine("Enter the id::");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ipr.UpdatePolicy(id);
                        Console.WriteLine();
                        
                        break;

                    case 4:
                        Console.WriteLine("Enter the valid Id::");
                        int search = Convert.ToInt32(Console.ReadLine());
                        ipr.DeletePolicy(search);
                        break;

                    //case 6:
                    //    Console.WriteLine();
                    //    ipr.ActivePolicies();
                    //    Console.WriteLine();
                    //    break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Please enter the valid choice");
                        break;
                }
            }
        }
    }
}
