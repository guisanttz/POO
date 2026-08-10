using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exemplos de instâncias...");
        //Declaração da variável c1, do tipo Conta
        Conta c1;
        //Instancia de um objeto
        //c1 está recebendo uma alocação de memória por meio da instrução new e chamando o construtor da classe Conta()
        c1 = new Conta();
        //como utilizar o objeto
        c1.numero = 19;
    }
}