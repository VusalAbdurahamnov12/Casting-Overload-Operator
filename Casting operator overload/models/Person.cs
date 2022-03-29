using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_operator_overload.models
{
    abstract class Person
    {
        public abstract int ID { get; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract int Age { get; set; }
        public abstract string ShowInfo();
    }
}
