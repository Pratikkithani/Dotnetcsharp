namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int studentAge;
            double studentPercentage;

            Console.Write("Enter the student's name: ");
            studentName = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter the student's age: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out studentAge))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a numeric value for age.");
                }
            }

            Console.Write("Enter the student's percentage: ");
            studentPercentage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nStudent Information:");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Percentage: {studentPercentage}%");

        }
    }
    }
}
