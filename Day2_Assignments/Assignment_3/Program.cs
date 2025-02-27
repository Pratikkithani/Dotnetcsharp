namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] username = { "Pratik", "Affan", "Sanchita" };
            double[] walletBalance = { 10000, 20000, 30000 };

        returnto:
            Console.WriteLine("Enter the username:");
            string user_name = Console.ReadLine();
            bool isUserFound = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (username[i] == user_name)
                {
                    Console.WriteLine($"{user_name}, your wallet balance is {walletBalance[i]}");
                    isUserFound = true;
                    break;
                }
            }

            if (!isUserFound)
            {
                Console.WriteLine("No user found");
                goto returnto;
            }
        }
    }
}
