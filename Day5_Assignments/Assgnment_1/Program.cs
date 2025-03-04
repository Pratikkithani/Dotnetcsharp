using Assgnment_1.Model;
using Assgnment_1.Repositories;

namespace Assgnment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccountRepository accRepo = new AccountRepository();
            List<Account> allaccs = accRepo.GetAllAccounts();
            Account acc4 = new Account();
            acc4.GetDetails();
            bool addStatus = accRepo.AddAccount(acc4);
            if (addStatus)
            {
                Console.WriteLine("Account Added Successfully");
            }
            else { Console.WriteLine("Try new id ::"); }

        }
    }
}
