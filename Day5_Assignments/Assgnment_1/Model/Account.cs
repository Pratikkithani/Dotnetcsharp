using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assgnment_1.Model
{
    internal class Account
    {
        public int AccountId { get; set; }

        public override string ToString()
        {
            return $"Id::{AccountId}";
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter the Account No.::");
            AccountId = Convert.ToInt32(Console.ReadLine());
        }
    }
}
