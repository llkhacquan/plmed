using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PLMED
{
    internal class Utility
    {
        //Get the connection string from App config file.  
        internal static string GetConnectionString()
        {
            //Util-2 Assume failure.  
            string returnValue = null;

            //Util-3 Look for the name in the connectionStrings section.  
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["PLMED.Properties.Settings.connString"];

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
    }
}
