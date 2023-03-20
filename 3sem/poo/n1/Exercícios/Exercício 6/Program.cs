using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Student student = new Student();
                do
                {
                    try
                    {
                        Console.WriteLine("Student's Name: ");
                        student.Name = Console.ReadLine();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (true);
                do
                {
                    try
                    {
                        Console.WriteLine("N1: ");
                        student.Grade1 = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (true);
                do
                {
                    try
                    {
                        Console.WriteLine("N2: ");
                        student.Grade2 = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (true);

                Console.WriteLine("Show average? Y/N");
                if (Console.ReadLine().ToUpper() != "N")
                {
                    Console.WriteLine(student.Average);
                }
                Console.WriteLine("Keep going? Y/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
                students.Add(student);
            }
            for( int i = 0; i < students.Count; i++ )
            {
                Console.WriteLine($"Name: {0}\nN1: {1}\nN2: {2}\nAverage:{3}", students[i].Name, students[i].Grade1, students[i].Grade2, students[i].Average );
            }
            Console.ReadKey();
        }
    }
}
