using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        Public string nome;
        Public double preco;
        Public int quantidade; 
        Public Produto(int Quantidade, double Preco, string Nome)
        { 
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
         }
    public double = ValorTotalEstoque() { }
        Return Preco * Quantidade;

}
    public void ExibirDetalhesProduto()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nome: {Preco}");
            Console.WriteLine($"Nome: {Quantidade}");
        }

            }
}
