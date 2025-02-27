using assignment2.Model;

namespace assignment2
{

    public class Program
    {
        static void Main(string[] args)
        {
            Empolyee emp = new Manager("Pratik",25000,5000);
            emp.displayDetails();

            ((Empolyee)emp).displayDetails();
        }
    }
}
