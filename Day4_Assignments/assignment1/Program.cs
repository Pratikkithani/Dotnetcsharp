namespace assignment1
{
    public class Countplease
    {
        public static int c = 0;
        public Countplease()
        {
            c++;
        }

        public void print()
        {
            Console.WriteLine(c);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Countplease countplease1 = new Countplease();
            countplease1.print();
            Countplease countplease2 = new Countplease();
            Countplease countplease3 = new Countplease();
            Countplease countplease4 = new Countplease();
            Countplease countplease5 = new Countplease();
            Countplease countplease6 = new Countplease();
            Countplease countplease7 = new Countplease();
            Countplease countplease8 = new Countplease();

            countplease1.print();


        }


    }


}
