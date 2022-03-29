using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_operator_overload.models.Exception
{
    internal class Teacher : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                    _salary = value;
            }
        }
        public override int ID { get; }

        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age { get; set; }

        public override string ShowInfo()
        {
            return $"\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nSalary:{Salary}";
        }
        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }

        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }
        public Teacher()
        {

        }
    }
}
