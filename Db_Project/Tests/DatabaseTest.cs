using System;
using Core;
using Xunit;

namespace Tests {
    public class DatabaseTest {

        private const int DatabaseCapacity = 16;

        private Database database = new Database();

        [Fact]
        public void Deve_Retornar_Excecao_Caso_Construtor_Receba_Mais_De_16_Parametros() {

            Assert.Throws<InvalidOperationException>(() => {
                new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
            });
        }

        [Fact]
        public void Deve_Retornar_Excecao_Quando_Database_Estiver_Cheio() {

            AdicionarNumeros(16);

            Assert.Throws<InvalidOperationException>(() => {
                database.Add(1);
            });
        }

        [Fact]
        public void Deve_Retornar_Excecao_Quando_Remover_Numero_Do_Database_E_Estiver_Vazio() {
            Assert.Throws<InvalidOperationException>(() => {
                database.Remove();
            });
        }

        private void AdicionarNumeros(int count) {
            for (int i = 0; i <= count; i++) {
                database.Add(i);
            }
        }

        private void RemoverNumeros(int count) {
            for (int i = 0; i < count; i++) {
                database.Remove();
            }
        }
    }
}