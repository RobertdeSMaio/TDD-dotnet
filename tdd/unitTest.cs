using Xunit;
using Proj;

namespace tdd
{
    public class UnitTest
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2020"

            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.somar(val1,val2);

            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(4,2,2)]
        [InlineData(5,5,0)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.somar(val1,val2);

            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(1,2,2)]
        [InlineData(4,5,20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.multiplicar(val1,val2);

            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(10,2,5)]
        [InlineData(5,5,1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculado = calc.dividir(val1,val2);

            Assert.Equal(resultado, resultadoCalculado);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.divisao(3,0)
            );
        }
        public void TesteHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1,6);
            calc.somar(8,10);
            calc.somar(29,2);
            calc.somar(31,6);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}