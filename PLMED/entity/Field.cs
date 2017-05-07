using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMED.entity
{
    internal abstract class Field
    {
        internal readonly String nameInDB;

        internal abstract void setValue(Object o);
        internal abstract Object getValue();

        internal Field(String name)
        {
            this.nameInDB = name;
        }
    }

    internal class StringField : Field
    {
        internal readonly int length;
        internal string data;

        public StringField(string name, int length) : base(name)
        {
            this.length = length;
        }

        internal override object getValue()
        {
            return data;
        }

        internal override void setValue(object o)
        {
            data = (String)o;
        }

        internal int getLength()
        {
            return length;
        }
    }

    internal class DateField : Field
    {
        internal DateTime date;

        public DateField(string name) : base(name)
        {
        }

        internal override object getValue()
        {
            return date;
        }

        internal override void setValue(object o)
        {
            date = (DateTime)o;
        }
    }

    internal class IntegerField : Field
    {
        internal int data;

        public IntegerField(string name) : base(name)
        {
        }

        internal override object getValue()
        {
            return data;
        }

        internal override void setValue(object o)
        {
            this.data = (int)o;
        }
    }
}
