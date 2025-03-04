using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoilicyHackathon.Model;

namespace PoilicyHackathon.Repository
{
    internal interface IPolicyRepository
    {
        public void AddPolicy(Poilcy policy);
        public void ViewAllPolicies();
        public void SearchPolicyById(int id);
        public void UpdatePolicy(Poilcy policy);
        public void DeletePolicy(int id);
        public void ActivePolicies();

    }
}
