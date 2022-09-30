using System;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Número natural: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++) {
                if (num % i == 0) {
                    Console.WriteLine("É composto");
                    return;
                }
            }
            Console.WriteLine("É primo");
        }
    }
}