using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10._1
{
    class MyDerivedClass : MyClass
    {
        public override string GetString() => base.GetString() + "(output from derived class)";
    }
}
