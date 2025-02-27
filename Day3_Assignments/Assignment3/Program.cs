namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string password;

            while (true)
            {
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                if (password.Length < 6)
                {
                    Console.WriteLine("Password must be at least 6 characters long.");
                }
                else if (!HasUpperCase(password))
                {
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                }
                else if (!HasDigit(password))
                {
                    Console.WriteLine("Password must contain at least one digit.");
                }
                else
                {
                    Console.WriteLine("Password is valid.");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Enter again:");
                password = Console.ReadLine();

            }
        }

        static bool HasUpperCase(string text)
        {
            foreach (char c in text)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        static bool HasDigit(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }
    }
}
