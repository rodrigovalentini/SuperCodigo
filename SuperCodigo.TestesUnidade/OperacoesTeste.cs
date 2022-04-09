using System;
using Xunit;
using Xunit.Abstractions;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTeste
    {
        private readonly ITestOutputHelper output;

        public OperacoesTeste(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData("a1b2c3z", "c")]
        [InlineData("a1b2c3z", "d")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "c")]
        [InlineData("", "c")]
        [InlineData("a1b2c3z", "cd")]
        [InlineData("a1b2c3z", "")]
        public void ObterPosicaoCaractereTeste(string a, string b)
        {
            int result = Operacoes.ObterPosicaoCaractere(a, b);
            output.WriteLine("A saída esperada é: {0}", result);
        }
        [Theory]
        [InlineData(6)]
        [InlineData(-2)]
        [InlineData(2)]
        public void ObterElementoFibonnaciTeste(int n)
        {
            int result = Operacoes.ObterElementoFibonnaci(n);
            output.WriteLine("O elemento é: {0}", result);
        }
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 1)]
        [InlineData(2, 3, 4)]
        public void DeterminarTipoTrianguloTeste(int a, int b, int c)
        {
            string result = Operacoes.DeterminarTipoTriangulo(a, b, c);
            output.WriteLine("O triângulo é: {0}", result);
        }
    }
}
