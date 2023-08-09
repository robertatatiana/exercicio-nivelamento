using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Nivelamento
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }   
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }

        public void MostrarDadosDoProduto()
        {
            Console.WriteLine("Dados do Produto:");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Quantidade em Estoque: " + Quantidade);
            Console.WriteLine("Valor Total em Estoque: " + ValorTotalEmEstoque());
        }

    }
}
