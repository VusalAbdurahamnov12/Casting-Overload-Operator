using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_operator_overload.models
{
    class Student : Person
    {
        private int _id;
        public override int ID { get; }

        public override string Name { get; set; }
        public override string Surname { get; set; }
        public double Point { get; set; }
        public override int Age { get; set; }

        public Student()
        {
            _id++;
            ID = _id;
        }
        public Student(string name, string surname, int age,double point):this()
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            Point = point;
        }

        public override string ShowInfo()
        {
            return $"ID{ID}\nName{Name}\nSurname{Surname}\nAge{Age}";
        }
        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.Point > stu2.Point;
        }
        public static bool operator <(Student stu1, Student stu2)
        {
            return stu2.Point < stu1.Point;
        }
    }
}
