using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PoilicyHackathon.Constants;
using PoilicyHackathon.Exception;
using PoilicyHackathon.Model;

namespace PoilicyHackathon.Repository
{
    internal class PolicyRepository : IPolicyRepository
    {
        Dictionary<int,Poilcy> _policies = new Dictionary<int, Poilcy>();

        public void AddPolicy(Poilcy policy)
        {
            if (_policies.ContainsKey(policy.PolicyID))
            {
                Console.WriteLine("Already present");
            }
            else
            {
                _policies[policy.PolicyID] = policy;
            }
        }

        public void ViewAllPolicies()
        {
            foreach(var item in _policies.Values)
            {
                Console.WriteLine(item);
            }
        }

        public void SearchPolicyById(int id)
        {
            if (_policies.ContainsKey(id))
            {
                Console.WriteLine($"PolicyID: {_policies[id].PolicyID}, PolicyHolderName: {_policies[id].PolicyHolderName}, PolicyType: {_policies[id].PolicyType}, StartDate: {_policies[id].StartDate.ToShortDateString()}, EndDate: {_policies[id].EndDate.ToShortDateString()}");

            }
        }

        public void UpdatePolicy(int id)
        {
            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Update Name\n2. Update End Date\n3. Update Policy Type\n4. Exit");
                Console.WriteLine("---------------------");
                Console.WriteLine("Enter the choice::");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Enter the Name::");
                        string name = Console.ReadLine();
                        _policies[id].PolicyHolderName = name;
                        break;

                    case 2:
                        DateTime start = DateTime.Now;
                        Console.WriteLine($"Start Date is {start}");
                        Console.WriteLine("Enter End Date (yyyy-MM-dd): ");
                        DateTime end = DateTime.Parse(Console.ReadLine());
                        _policies[id].StartDate = start;
                        _policies[id].EndDate = end;
                        break;

                    case 3:
                        Console.WriteLine("Policy type");
                        Console.WriteLine("1. Life\n2. Health\n3. Vehicle\n4. Property");
                        Console.WriteLine("Enter which you want::");
                        PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());
                        _policies[id].PolicyType = type;
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;
                }
            }
        }

        public void DeletePolicy(int id)
        {
            try
            {
                if (_policies.ContainsKey(id))
                {
                    _policies.Remove(id);

                }
                else
                {
                    throw new PolicyNotFound("not found");

                }
            }
            catch(PolicyNotFound exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public void ActivePolicies()
        {
            foreach(var item in _policies.Values)
            {
                if (item.IsActive())
                {
                    Console.WriteLine(item);
                }
            }
        }




    }
}
