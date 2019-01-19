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

            AdicionarNumeros(15);

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

        [Theory]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        [InlineData(6, 6)]
        public void Fetch_Deve_Retornar_Quantidade_De_Numeros_No_Databse(int qtdNumeros, int resultadoEsperado) {
            AdicionarNumeros(qtdNumeros);

            Assert.Equal(qtdNumeros, resultadoEsperado);
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(6, 1)]
        [InlineData(6, 5)]
        public void Fetch_Deve_Retornar_Quantidade_De_Numeros_Corretos_Depois_De_Remover_No_Databse(int qtdNumeros, int numeroDeRemocoes) {

            AdicionarNumeros(qtdNumeros);

            RemoverNumeros(numeroDeRemocoes);

            Assert.Equal(database.Fetch().Length, qtdNumeros - numeroDeRemocoes);
        }

        private void AdicionarNumeros(int count) {
            for (int i = 0; i <= count; i++) {
                database.Add(i);
            }
        }

        private void RemoverNumeros(int count) {
            for (int i = 0; i <= count; i++) {
                database.Remove();
            }
        }
    }
}