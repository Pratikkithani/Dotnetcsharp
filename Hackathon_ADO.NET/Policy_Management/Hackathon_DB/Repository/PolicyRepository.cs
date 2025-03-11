using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hackathon_DB.Constant;
using Hackathon_DB.Exception;
using Hackathon_DB.Model;
using Hackathon_DB.Utility;

namespace Hackathon_DB.Repository
{
    internal class PolicyRepository : IPolicyRepository
    {
        SqlCommand cmd = null;
        string connstring;

        public PolicyRepository()
        {
            cmd = new SqlCommand();
            connstring = DbConnUtil.GetConnectionString();
        }

        public int AddPolicy(Policy policy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into Policies(PolicyHolderName,PolicyType,StartDate,EndDate) values(@PolicyHolderName,@PolicyType,@StartDate,@EndDate)";
                cmd.Parameters.AddWithValue("@PolicyHolderName", policy.PolicyHolderName);
                cmd.Parameters.AddWithValue("@PolicyType", policy.PolicyType);
                cmd.Parameters.AddWithValue("@StartDate", policy.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", policy.EndDate);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public List<Policy> ViewAllPolicies()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                List<Policy> policies = new List<Policy>();
                cmd.CommandText = "select * from Policies";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Policy policy = new Policy();
                    policy.PolicyID = reader.GetInt32("PolicyID");
                    policy.PolicyHolderName = reader.GetString("PolicyHolderName");
                    policy.PolicyType = (PolicyType)reader["PolicyType"];
                    policy.StartDate = reader.GetDateTime("StartDate");
                    policy.EndDate = reader.GetDateTime("EndDate");
                    policies.Add(policy);
                }
                return policies;

            }
        }

        public void SearchPolicyById(int id)
        {
            List<Policy> policies = ViewAllPolicies();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "select * from Policies where PolicyID=@PolicyID";
                cmd.Parameters.AddWithValue("@PolicyID", id);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    if (!policies.Any(p => p.PolicyID == id))
                    {
                        throw new PolicyNotFound("Not Found");
                    }

                    if (reader.Read())
                    {
                        Policy policy = new Policy();
                        policy.PolicyID = reader.GetInt32("PolicyID");
                        policy.PolicyHolderName = reader.GetString("PolicyHolderName");
                        policy.PolicyType = (PolicyType)reader["PolicyType"];
                        policy.StartDate = reader.GetDateTime("StartDate");
                        policy.EndDate = reader.GetDateTime("EndDate");
                        Console.WriteLine($"PolicyID: {policy.PolicyID}, PolicyHolderName: {policy.PolicyHolderName}, PolicyType: {policy.PolicyType}, StartDate: {policy.StartDate.ToShortDateString()}, EndDate: {policy.EndDate.ToShortDateString()}, IsActive: {policy.IsActive()}");
                    }
                }
                catch (PolicyNotFound ex)
                {
                    Console.WriteLine(ex.Message);
                }
       
            }
        }


        public int UpdatePolicy(int id)
        {
            List<Policy> policies = ViewAllPolicies();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                try
                {
                    if (!policies.Any(p => p.PolicyID == id))
                    {
                        throw new PolicyNotFound("Not Found");
                    }

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
                                cmd.Parameters.Clear();
                                cmd.CommandText = "Update Policies set PolicyHolderName=@PolicyHolderName where PolicyID=@PolicyID";
                                cmd.Parameters.AddWithValue("@PolicyID", id);
                                cmd.Parameters.AddWithValue("@PolicyHolderName", name);
                                cmd.ExecuteNonQuery();
                                break;

                            case 2:
                                DateTime start = DateTime.Now;
                                Console.WriteLine($"Start Date is {start}");
                                Console.WriteLine("Enter End Date (yyyy-MM-dd): ");
                                DateTime end = DateTime.Parse(Console.ReadLine());
                                cmd.Parameters.Clear();
                                cmd.CommandText = "Update Policies set EndDate=@EndDate where PolicyID=@PolicyID";
                                cmd.Parameters.AddWithValue("@PolicyID", id);
                                cmd.Parameters.AddWithValue("@EndDate", end);
                                cmd.ExecuteNonQuery();
                                break;

                            case 3:
                                Console.WriteLine("Policy type");
                                Console.WriteLine("1. Life\n2. Health\n3. Vehicle\n4. Property");
                                Console.WriteLine("Enter which you want::");
                                PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());
                                cmd.Parameters.Clear();
                                cmd.CommandText = "Update Policies set PolicyType=@PolicyType where PolicyID=@PolicyID";
                                cmd.Parameters.AddWithValue("@PolicyID", id);
                                cmd.Parameters.AddWithValue("@PolicyType", type);
                                cmd.ExecuteNonQuery();
                                break;

                            case 4:
                                return cmd.ExecuteNonQuery();

                            default:
                                Console.WriteLine("enter the valid choice");
                                break;
                        }

                    }
                }
                catch (PolicyNotFound ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }


            }
        }
        
        public int DeletePolicy(int id)
        {
            List<Policy> policies = ViewAllPolicies();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                try
                {
                    if (policies.Any(p=>p.PolicyID==id))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "Delete from Policies where PolicyID=@PolicyID";
                        cmd.Parameters.AddWithValue("@PolicyID", id);
                        cmd.Connection = sqlConnection;
                        sqlConnection.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new PolicyNotFound("Not Found");

                    }
                }
                catch (PolicyNotFound ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }

        public void ActivePolicies()
        {
            List<Policy> policies = ViewAllPolicies();
            foreach (Policy item in policies)
            {
                if (item.IsActive())
                {
                    Console.WriteLine(item);
                }
            }
        }

        public int DeleteAllData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.CommandText = "truncate table Policies";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                bool permission = false;
                Console.WriteLine("Are you sure you want to delete?(y/n)");
                string takeper = Console.ReadLine();
                if (takeper=="y")
                {
                    Console.WriteLine("Data Successfully Deleted");
                    return cmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("sorry can't delete");
                    return 0;
                }
            }
        }
    }
}
