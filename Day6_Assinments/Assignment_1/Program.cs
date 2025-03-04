namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> customerqueue = new Queue<int>();
            int token = 1;
            int choice;
            Console.WriteLine("1. Add new customer");
            Console.WriteLine("2. Next customer");
            Console.WriteLine("3. Remove served customer");
            Console.WriteLine("4. Know the total customers in the line");
            Console.WriteLine("5. Exit");
            while (true)
            {
                Console.WriteLine("Enter your Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        customerqueue.Enqueue(token);
                        Console.WriteLine($"Customer{token} added successfuly");
                        token++;
                        break;
                    case 2:
                        if (customerqueue.Count > 0)
                        {
                            Console.WriteLine($"Token Number of Next customer in the queue is {customerqueue.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("customer queue is empty");
                        }
                        break;
                    case 3:
                        if (customerqueue.Count > 0)
                        {
                            Console.WriteLine($"Customer {customerqueue.Dequeue()} served successfuly");
                        }
                        else
                        {
                            Console.WriteLine("customer queue is empty");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"total customers in the line are {customerqueue.Count()}");
                        break;
                    case 5:
                        Console.WriteLine("Exiting the system");
                        return;
                    default:
                        Console.WriteLine("invalid input please enter valid input (1-4)");
                        break;
                }
            }
        }
    }
}