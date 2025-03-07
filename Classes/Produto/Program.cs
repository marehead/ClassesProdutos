using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto chocolate = new Produto("Cacau Show", 30.00, 100);
            Produto refrigerante = new Produto("Pepsi", 8.00, 500);

            Produto chinelo = new Produto();

            chinelo.Nome = "Havaianas";
            chinelo.Preco = 40.00;
            chinelo.Quantidade = 50;

            refrigerante.Preco = 10.00;

            refrigerante.ExibirDetalhesProduto();
            Console.WriteLine();
            chocolate.ExibirDetalhesProduto();
            Console.WriteLine();
            chinelo.ExibirDetalhesProduto();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Valor total em estoque de {chocolate.Nome}: {chocolate.ValorTotalEstoque()}")
            chocolate.ValorTotalEstoque();
        }
    }
}
