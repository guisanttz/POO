using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int qntd;

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {nome}\tPreço: {preco:c}\tQuantidade: {qntd}");
        }

        public void AdicionarProduto(int qte)
        {
            qntd += qte;
        }

        public void RemoverProduto(int qte)
        {
            qntd -= qte;
        }

        public double ValorTotalEstoque()
        {
            return qntd * preco;
        }

    }
}