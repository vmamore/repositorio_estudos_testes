using System;

namespace Core {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Database db = new Database(1, 2, 3, 4, 5, 6, 7);
            System.Console.WriteLine(db.Fetch());
        }
    }
}