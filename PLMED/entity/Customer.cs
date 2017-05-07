using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMED.entity
{
    internal class Customer : Entity
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String TaxCode { get; set; }
        public String Category { get; set; }
        public String Address { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }
        public String Contact { get; set; }

        Table Entity.getTable()
        {
            return Table.CustomerTable;
        }
    }
}