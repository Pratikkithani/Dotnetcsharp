using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assgnment_1.Exceptions;
using Assgnment_1.Model;

namespace Assgnment_1.Repositories
{
    class AccountRepository : IAccountRepository
    {
        //create a List
        List<Account> acounts;
        //constructor
        public AccountRepository()
        {
            //Initialising the list
            acounts = new List<Account>
            {
                new Account(){AccountId=123},
                new Account(){AccountId=456},
                new Account(){AccountId=789}
            };
        }

        public bool AddAccount(Account account)
        {
            try
            {
                Account searchResult = GetAccountById(account.AccountId);
                if (searchResult == null)
                {
                    acounts.Add(account);
                    return true;
                }

                else
                {
                    throw new InvalidAccountNumberException($"{account.AccountId} account no. already Exists");

                }

            }
            catch (InvalidAccountNumberException baex)
            {
                Console.WriteLine(baex.Message);
            }
            return false;
        }

        public List<Account> GetAllAccounts()
        {
            return acounts;
        }

        public Account GetAccountById(int account)
        {
            return acounts.Find(p => p.AccountId == account);
        }
    }
}
