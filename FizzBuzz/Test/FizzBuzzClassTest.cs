using FizzBuzz.Project;
using Xunit;

namespace Test {
    public class FizzBuzzClassTest {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(99)]
        public void Deve_Retornar_Buzz_Quando_Numero_For_Multiplo_De_3_E_Nao_Multiplo_De_5(int numero) {
            // Arrange
            var resultadoEsperado = "Buzz";
            // Act
            var retorno = FizzBuzzClass.Resultado(numero);

            // Assert
            Assert.Equal(resultadoEsperado, retorno);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void Deve_Retornar_Fizz_Quando_Numero_For_Multiplo_De_5_E_Nao_Multiplo_De_3(int numero) {
            // Arrange
            var resultadoEsperado = "Fizz";
            // Act
            var retorno = FizzBuzzClass.Resultado(numero);

            // Assert
            Assert.Equal(resultadoEsperado, retorno);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(90)]
        public void Deve_Retornar_FizzBuzz_Quando_Numero_For_Multiplo_De_5_E_Multiplo_De_3(int numero) {
            // Arrange
            var resultadoEsperado = "FizzBuzz!";
            // Act
            var retorno = FizzBuzzClass.Resultado(numero);

            // Assert
            Assert.Equal(resultadoEsperado, retorno);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(98)]
        public void Deve_Retornar_Numero_Quando_Numero_Nao_For_Multiplo_De_5_E_Nem_Multiplo_De_3(int numero) {
            // Arrange
            var resultadoEsperado = $"{numero}";
            // Act
            var retorno = FizzBuzzClass.Resultado(numero);

            // Assert
            Assert.Equal(resultadoEsperado, retorno);
        }
    }
}