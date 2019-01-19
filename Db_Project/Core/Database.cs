using System;
using System.Collections.Generic;
using System.Text;

namespace Core {
    public class Database {
        private int[] array = new int[16];
        public Database(params int[] elements) {
            foreach (var element in elements)
                Add(element);
        }

        public void Add(int number) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != 0)
                    continue;
                array[i] = number;
                return;
            }

            throw new InvalidOperationException("Database is full!");
        }

        public void Remove() {
            for (int i = array.Length - 1; i >= 0; i--) {
                if (array[i] == 0)
                    continue;
                array[i] = 0;
                return;
            }

            throw new InvalidOperationException("Database is empty!");
        }

        public string Fetch() {
            var dicionarioDeDados = new StringBuilder();
            for (int i = 0; i < array.Length; i++) {
                dicionarioDeDados.AppendFormat("{0} - {1}\n", i, array[i]);
            }
            return dicionarioDeDados.ToString();
        }
    }
}