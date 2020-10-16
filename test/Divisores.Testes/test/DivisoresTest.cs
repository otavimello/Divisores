using System;
using System.Collections.Generic;
using Divisores.Testes.src.Service.Divisores;
using Divisores.Testes.src.Service.DivisoresService;
using Xunit;

namespace Divisores.Testes
{
    
    public class DivisoresTest 
    {
        private readonly DivisoresService _divisores;
        public DivisoresTest(){
            _divisores=new DivisoresService();
        }
        [Fact]
        public void PassingDivisores2Test()
        {
            List<int> retornoesperado = new List<int>{1,2};
            var resultado =_divisores.BuscaDivisores(2);
            Console.WriteLine(resultado);
            Assert.Equal(retornoesperado, resultado);
        }
        [Fact]
        public void FalseDivisores2Test()
        {
            List<int> retornoesperado = new List<int>{1};
            var resultado =_divisores.BuscaDivisores(2);
            Console.WriteLine(resultado);
            Assert.NotEqual(retornoesperado, resultado);
        }
        [Theory]
        [InlineData(10)]
        public void DivisoresPrimos10Test(int entrada)
        {
            List<int> retornoesperado = new List<int>{2,5};
            var resultado =_divisores.BuscaDivisores(entrada);
            Console.WriteLine(resultado);
            Assert.NotEqual(retornoesperado, resultado);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void FalseDivisoresPrimosTest(int entrada)
        {
            List<int> retornoesperado = new List<int>();
            var resultado =_divisores.BuscaDivisoresPrimos(entrada);
            Console.WriteLine(resultado);
            Assert.False(resultado.Count>1);
        }
    }
}
