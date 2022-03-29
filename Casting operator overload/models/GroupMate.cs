using System;
using System.Collections.Generic;
using System.Text;
using static Casting_operator_overload.Exceptions.NotAvailableException;

namespace Casting_operator_overload.models
{
    internal class GroupMate
    {
        Student[] Studentt = new Student[0];
        public Student this[int index]
        {
            get
            {
                return Studentt[index];
            }
            set
            {
                Array.Resize(ref Studentt, Studentt.Length + 1);
                Studentt[index] = value;
            }
        }
        public void Sort()
        {
            if (Studentt.Length > 1)
            {
                for (int i = 0; i < Studentt.Length; i++)
                {
                    for (int j = i; j < Studentt.Length; j++)
                    {
                        if (Studentt[j] > Studentt[i])
                        {
                            Student temp = Studentt[j];
                            Studentt[j] = Studentt[i];
                            Studentt[i] = temp;
                        }
                    }
                    Print();
                }
            }
            else throw new NotAvailableExceptions("You must enter miniumu 2 elements ");
        }
        public void Print()
        {
            foreach (var student in Studentt)
            {
                Console.WriteLine(student);
            }
        }
    }
}                   
