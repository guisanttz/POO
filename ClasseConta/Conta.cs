using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Pasta
namespace ClasseConta
{
    public class Conta
    {
        //Declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero}\tTitular: {titular}\tSaldo: {saldo:c}");
        }

        //Declaração dos métodos(funções)
        public void Sacar(double valorSaque)
        {
            saldo -= valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
    }
}