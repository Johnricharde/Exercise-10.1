using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10._1
{
    class MyClass
    {
        protected string myString;
        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }
        public virtual string GetString() => myString;
    }
}
