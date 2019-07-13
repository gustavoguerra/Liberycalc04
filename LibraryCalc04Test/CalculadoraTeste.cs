using LibraryCalc04;
using System;
using Xunit;


namespace LibraryCalc04Test
{
    public class CalculadoraTeste
    {
        [Theory]
        [InlineData(10,15)]
        [InlineData(4, 1)]
        [InlineData(-10, -15)]
        [InlineData(10, -15)]
        public void SomaSucesso(double x, double y)
        {
            var calculadora = new Calculadora();

            var result = calculadora.Soma(x, y);

            Assert.True((x + y) == result);
        }
        [Theory]
        [InlineData(10, 15)]
        [InlineData(4, 1)]
        [InlineData(-10, -15)]
        [InlineData(10, -15)]
        public void SubSucesso(double x, double y)
        {
            var calculadora = new Calculadora();
            
            var result = calculadora.Subtra(x, y);

            Assert.True((x - y) == result);
        }
        [Theory]
        [InlineData(10, 15)]
        [InlineData(4, 1)]
        [InlineData(-10, -15)]
        [InlineData(10, -15)]
        public void MultSucesso(double x, double y)
        {
            var calculadora = new Calculadora();
            
            var result = calculadora.Multi(x, y);

            Assert.True((x * y) == result);
        }
        [Theory]
        [InlineData(10, 15)]
        [InlineData(4, 1)]
        [InlineData(-10, -15)]
        [InlineData(10, -15)]
        public void DivSucesso(double x, double y)
        {
            var calculadora = new Calculadora();
            
            var result = calculadora.Divi(x, y);

            Assert.True((x / y) == result);
        }

        [Theory]
        [InlineData(10, 15, 1)]
        [InlineData(4, 1 , 10)]
        [InlineData(-10, -15, 50)]
        [InlineData(10, -15, -20)]
        public void SomaSucesso2(double x, double y, double z)
        {
            var calculadora = new Calculadora();

            var result = calculadora.Soma(x, y, z);

            Assert.True((x + y + z) == result);
        }

        [Theory]
        [InlineData(10, 15, 2)]
        [InlineData(4, 1, -74)]
        [InlineData(-10, -15, -69)]
        [InlineData(10, -15 , 96)]
        public void SubSucesso2(double x, double y, double z)
        {
            var calculadora = new Calculadora();

            var result = calculadora.Subtra(x, y, z);

            Assert.True((x - y - z) == result);
        }
    }
}
