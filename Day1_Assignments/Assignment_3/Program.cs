namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentEmail;
            Console.Write("Enter the student's email: ");
            studentEmail = Console.ReadLine();

            while (studentEmail == "")
            {
                Console.WriteLine("Email cannot be empty. Please enter a valid email.");
                Console.Write("Enter the student's email: ");
                studentEmail = Console.ReadLine();
            }


            Console.WriteLine($"\nStudent's Email: {studentEmail}");

        }
    }
}
