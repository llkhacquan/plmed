using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PLMED.entity;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PLMED
{
    internal class Utility
    {
        internal static string CUSTOM_STRING = null;
        //Get the connection string from App config file.  
        internal static string GetConnectionString()
        {
            if (CUSTOM_STRING != null)
                return CUSTOM_STRING;
            //Util-2 Assume failure.  
            string returnValue = null;

            //Util-3 Look for the name in the connectionStrings section.  
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["PLMED.Properties.Settings.connString"];
            //If found, return the connection string.  
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        private static Random random = new Random();
        internal static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        internal static List<Customer> loadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdSelectCustomer = new SqlCommand("SELECT * from [Sales].[Customer]", conn);
            try
            {
                conn.Open();
                SqlDataReader customersReader = cmdSelectCustomer.ExecuteReader();

                while (customersReader.Read())
                {
                    Customer c = new Customer();
                    c.id = (int)customersReader["id"];
                    c.Name = (string)customersReader["name"];
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu về khách hàng!\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }

        internal static List<Staff> loadStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand cmdSelectCustomer = new SqlCommand("SELECT * from [Sales].[Staff]", conn);
            try
            {
                conn.Open();
                SqlDataReader staffsReader = cmdSelectCustomer.ExecuteReader();

                while (staffsReader.Read())
                {
                    Staff c = new Staff();
                    c.id = (int)staffsReader["id"];
                    c.Name = (string)staffsReader["name"];
                    staffs.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu về khách hàng!\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return staffs;
        }
    }


}
