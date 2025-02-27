namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            double basicSalary = salary;
            Console.WriteLine("Enter your rating:");
            int rating = Convert.ToInt32(Console.ReadLine());

            salary = salary - salary * 0.1;

            if (rating >= 8)
            {
                salary = salary + salary * 0.2;
            }
            else if (rating >= 5)
            {
                salary = salary + salary * 0.1;
            }

            Console.WriteLine($"Salary of employee: {basicSalary} and the computed salary is {salary}");
        }
    }
}
