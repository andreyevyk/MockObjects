using Microsoft.VisualStudio.TestTools.UnitTesting;
using mockObjects;
using Moq;

namespace mockObjectsTestes
{
    [TestClass]
    public class mockObjectTest
    {
        [TestMethod]
        public void ValidaVerificadorPrecoProdutoBarata()
        {
            Produto produtoBarato = new Produto()
            {
                Preco = 30,
            };

            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato)).Returns("Produto barato!");

            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);

            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void ValidaVerificadorPrecoProdutoMediadePreco()
        {
            Produto produtoMedio = new Produto()
            {
                Preco =150,
            };

            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoMedio)).Returns("Produto caro!");

            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoMedio);
            var resultado = verif.VerificaPrecoProduto(produtoMedio);

            Assert.AreEqual(resultado, resultadoEsperado);
        }

    }
}
