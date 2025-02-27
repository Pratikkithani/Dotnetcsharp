namespace Assignment_1
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

            Console.Write("Enter the student's Age: ");
            studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the student's percentage: ");
            studentPercentage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nStudent Information:");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Percentage: {studentPercentage}%");

        }
    }
}
