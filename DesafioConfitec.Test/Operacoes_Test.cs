using System;
using Xunit;
using DesafioConfitec.Business.Service;
using DesafioConfitec.Test.Config;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioConfitec.Test
{
    public class Operacoes_Test
    {
        private ServiceProvider serviceProvider;
        private IOperacoesService operacoes;

        public Operacoes_Test()
        {
            this.serviceProvider = DependencyInjectionContainer.GetServiceScopeFactory();
            this.operacoes = this.serviceProvider.GetService<IOperacoesService>();
        }

        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(13, -5, 8)]
        [InlineData(-33, 13, -20)]
        [InlineData(300, 200, 500)]
        public void Somar_Test(double valor1, double valor2, double esperado)
        {
            double resultado = this.operacoes.Somar(valor1, valor2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(15, 8, 7)]
        [InlineData(-25, 30, -55)]
        [InlineData(-12, -8, -4)]
        [InlineData(900, 388, 512)]
        public void Subtrair_Test(double valor1, double valor2, double esperado)
        {
            double resultado = this.operacoes.Subtrair(valor1, valor2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(4, 6, 24)]
        [InlineData(25, 15, 375)]
        [InlineData(-5, 10, -50)]
        [InlineData(7.8, 9.33, 72.774)]
        public void Multiplicar_Test(double valor1, double valor2, double esperado)
        {
            double resultado = this.operacoes.Multiplicar(valor1, valor2);

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20.4, 4, 5.1)]
        [InlineData(32.6, 8.4, 3.880952380952381)]
        public void Dividir_Test(double valor1, double valor2, double esperado)
        {
            double resultado = this.operacoes.Dividir(valor1, valor2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void DividirPorZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => {
                double resultado = this.operacoes.Dividir(5,0);
            });
        }
    }
}
