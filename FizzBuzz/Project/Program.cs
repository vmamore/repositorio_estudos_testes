using System;

namespace FizzBuzz.Project {
    class Program {
        static void Main(string[] args) {
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(FizzBuzzClass.Resultado(i));
            }
        }
    }
}