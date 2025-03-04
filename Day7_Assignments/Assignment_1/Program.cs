using Assignment_1.Model;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Pratik",
                Deparment = "IT",
                DateOfJoining = new DateOnly(2024, 1, 5)
            };

            employee.CalculateExperience();

        }
    }
}
