using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void UpdatePolicy(Poilcy policy)
        {
            if (_policies.ContainsKey(policy.PolicyID))
            {
                _policies[policy.PolicyID] = policy;
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
