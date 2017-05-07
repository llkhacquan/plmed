using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMED.entity
{
    internal class Table
    {
        internal readonly String name;
        internal Field[] fields;
        String loadDataQuery;
        String deleteDataQuery;
        String searchDataQuery;
        String updateDataQuery;

        internal Table(string name, Field[] fields)
        {
            this.name = name;
            this.fields = fields;
        }

        internal static readonly Table CustomerTable = new Table("[Sales].[Customer]", new Field[] {
            new IntegerField("id"),
            new StringField("name", 100),
            new StringField("taxcode", 100),
            new StringField("category", 100),
            new StringField("address", 100),
            new StringField("telephone", 100),
            new StringField("email", 100),
            new StringField("contact", 100)
        });

        internal static readonly Table StaffTable = new Table("[Sales].[Staff]", new Field[] {
            new IntegerField("id"),
            new StringField("code", 100),
            new StringField("name", 100),
            new StringField("telephone", 100),
            new StringField("position", 100),
            new StringField("address", 100),
            new DateField("start"),
            new DateField("birthday")
        });

        internal static readonly Table ProductTable = new Table("[Sales].[Product]", new Field[] {
            new IntegerField("id"),
            new StringField("code", 100),
            new StringField("name", 100),
            new StringField("price", 100),
            new StringField("type", 100)
        });
    }
}
