using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core {
    public class Database {
        private const int DatabaseCapacity = 16;
        private int count;
        private int[] array;
        public Database() {
            array = new int[DatabaseCapacity];
        }
        public Database(params int[] elements) : this() {
            foreach (var element in elements)
                Add(element);
        }

        public void Add(int number) {
            if (count == DatabaseCapacity)
                throw new InvalidOperationException("Database is full!");

            array[count] = number;
            count++;
        }

        public void Remove() {
            if (count == 0)
                throw new InvalidOperationException("Database is empty!");

            count--;
        }

        public int Count() => this.count;
        public int[] Fetch() => array.Take(count).ToArray();
    }
}