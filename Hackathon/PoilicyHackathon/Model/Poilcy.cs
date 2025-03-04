using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PoilicyHackathon.Constants;

namespace PoilicyHackathon.Model
{
    internal class Poilcy
    {
        public int PolicyID { get; set; }
        public string PolicyHolderName { get; set; }
        public PolicyType PolicyType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Poilcy(int policyID, string policyHolderName, PolicyType policyType, DateTime startDate, DateTime endDate)
        {
            PolicyID = policyID;
            PolicyHolderName = policyHolderName;
            PolicyType = policyType;
            StartDate = startDate;
            EndDate = endDate;
        }
        public override string ToString()
        {
            return $"PolicyID: {PolicyID}, PolicyHolderName: {PolicyHolderName}, PolicyType: {PolicyType}, StartDate: {StartDate.ToShortDateString()}, EndDate: {EndDate.ToShortDateString()}, IsActive: {IsActive()}";
        }
        public bool IsActive()
        {
            return DateTime.Now >= StartDate && DateTime.Now <= EndDate;
        }
    }
}
