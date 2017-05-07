using PLMED.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
{
    internal class IDetailForm : Form
    {
        protected bool editMode;
        protected bool result;
        internal virtual SqlCommand load(Type type, string query)
        {
            Table t = null;
            if (type == typeof(Customer))
            {
                t = Table.CustomerTable;
            }
            else if (type == typeof(Staff))
            {
                t = Table.StaffTable;
            }
            else if (type == typeof(Product))
            {
                t = Table.ProductTable;
            }
            else
            {
                throw new Exception("Cannot detect type of T : " + type);
            }
            StringBuilder sql = new StringBuilder("SELECT * FROM " + t.name);
            if (query == null || query.Length == 0)
            {
            }
            else
            {
                query = query.ToUpper();
                sql.Append("\nWHERE ");
                foreach (Field f in t.fields)
                {
                    sql.Append("UPPER(");
                    if (f is StringField)
                    {
                        sql.Append(f.nameInDB);
                    }
                    else if (f is DateField)
                    {
                        sql.Append("FORMAT(").Append(f.nameInDB).Append(",'dd/MM/yyyy')");
                    }
                    else
                    {
                        sql.Append("STR(").Append(f.nameInDB).Append(") ");
                    }
                    sql.Append(")");
                    sql.Append(" like '%").Append(query).Append("%' ");
                    sql.Append("\nOR ");
                }
                sql.Remove(sql.Length - 4, 4);
            }
            return new SqlCommand(sql.ToString());
        }
        internal virtual Boolean delete(int id)
        {
            throw new NotImplementedException();
        }
        internal virtual Boolean create()
        {
            throw new NotImplementedException();
        }
        internal virtual Boolean update(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }
    }
}
