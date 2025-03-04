using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assgnment_1.Model;

namespace Assgnment_1.Repositories
{
    interface IAccountRepository
    {
        bool AddAccount(Account account);
        List<Account> GetAllAccounts();
        Account GetAccountById(int name);
    }
}
