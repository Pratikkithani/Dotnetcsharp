using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon_DB.Model;

namespace Hackathon_DB.Repository
{
    internal interface IPolicyRepository
    {
        public int AddPolicy(Policy policy);
        public List<Policy> ViewAllPolicies();
        public void SearchPolicyById(int id);
        public int UpdatePolicy(int id);
        public int DeletePolicy(int id);
        public void ActivePolicies();
        public int DeleteAllData();

    }
}
