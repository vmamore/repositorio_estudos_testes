﻿using System;

namespace Core {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Database db = new Database(1, 2, 3, 4, 5, 6, 7);

            foreach (var numero in db.Fetch())
                System.Console.WriteLine(numero);
        }
    }
}