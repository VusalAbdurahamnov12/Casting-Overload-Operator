using System;
using static Casting_operator_overload.Exceptions.NotAvailableException;
using Casting_operator_overload.models;
using Casting_operator_overload.models.Exception;

namespace Casting_operator_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] teacherss = new Teacher[0];
            Person[] studentss = new Student[0];
            GroupMate groupmate = new GroupMate();
            int choice;
            do
            {
            choicePoint:
                try {
                    Console.WriteLine("[1]-Create student\n[2]-Create teacher\n[3]-Ifno,0-Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                }catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    goto choicePoint;
                }
                
                 switch (choice)
                {
                    case 0:
                        break;
                    case 1://Create studend 
                        Name(out string studentName);
                        Surname(out string studentSurname);
                        StudentAge(out int studentAge);
                        Point(out double point);
                        Person newstudent = new Student(studentName, studentSurname, studentAge, point);
                        Array.Resize(ref studentss, studentss.Length + 1);
                        studentss[studentss.Length - 1] = newstudent;
                        break;
                    case 2://Create Teacher
                        Name(out string teacherName);
                        Surname(out string teacherSurname);
                        TeacherAge(out int teacherAge);
                        Salary(out double salary);
                        break;
                    case 3:
                        Console.WriteLine(studentss);
                        for (int i = 0; i < studentss.Length; i++)
                        {
                            Console.WriteLine(studentss[i]);
                        }
                        foreach (Person item in teacherss)
                            Console.WriteLine(item);
                        break;
                }
            } while (choice != 4);
        }
        static void Salary(out double salary)
        {
        Start:
            try
            {
                Console.Write("Salary:");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary < 0)
                    throw new NotAvailableExceptions("Salary must be greater than 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void TeacherAge(out int age)
        {
        TeacherAge:
            try
            {
                Console.Write("Age:");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)throw new NotAvailableExceptions("your age is not suitable.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto TeacherAge;
            }
        }
        //Studend 
        static void Name( out string name)
        {
        Name:
            try
            {
                Console.Write("Enter Name:");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name)) throw new NotAvailableExceptions("Ad daxil etmək məcburidir.");
                if (Double.TryParse(name, out double d)) 
                {
                    Console.WriteLine("Numbers not allowed!");
                    goto Name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Name;
            }

        }
        static void Surname(out string surname)
        {
        Surname:
            try
            {
                Console.Write("Enter Surname:");
                surname = Console.ReadLine();
                if (String.IsNullOrEmpty(surname)) throw new NotAvailableExceptions("Soyad daxil etmək məcburidir.");
                if (Double.TryParse(surname, out double d))
                {
                    Console.WriteLine("Numbers not allowed!");
                    goto Surname;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Surname;
            }
        }
        static void StudentAge(out int age)
        {
        StudentAge:
            try
            {
                Console.Write("Age:");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 6 || age > 21)throw new NotAvailableExceptions("your age is not suitable.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto StudentAge;
            }
        }
        static void Point(out double point)
        {
        Point:
            try
            {
                Console.Write("Point:");
                point = Convert.ToInt32(Console.ReadLine());
                if (point < 0 || point > 100)throw new NotAvailableExceptions("Point must be 0-100interval.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point;
            }
        }
        
    }
}