using Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            while(true);

            Console.WriteLine("Show average? Y/N");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.WriteLine(student.Average);
            }
            Console.ReadKey();




        }
    }
}
