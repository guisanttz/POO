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
        c1.numero = 19;
        c1.titular = "Joãozinho";
        c1.saldo = 2700.50;
        c1.MostrarAtributos();
        Console.Write("Informe o valor a sacar: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        c1.Sacar(saque);        
        c1.MostrarAtributos();


        //Exemplo com digitação
        //Instanciação do objeto c2

        Conta c2 = new Conta();
        Console.Write("Informe o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Informe o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());
        c2.MostrarAtributos();
    }
}