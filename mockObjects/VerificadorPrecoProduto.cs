using System;
using System.Collections.Generic;
using System.Text;

namespace mockObjects
{ 
    public class VerificadorPrecoProduto : IVerificadorPrecoProduto
    {
        public string VerificaPrecoProduto(Produto p)
        {
            if (p.Preco > 100)
                return "Produto caro!";
            else if (p.Preco <= 100 && p.Preco > 40)
                return "Produto na média de preço!";
            else
                return "Produto barato!";
        }
    }

}
