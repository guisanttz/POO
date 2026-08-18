using ArrayConta;
//declaração de vetor com 3 indices
Conta[] vetConta = new Conta[3];

Console.WriteLine("Cadastro de Contas");
for (int i = 0;i < 3; i++)
{
    vetConta[i] = new Conta();
    Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetConta[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}

double saldoTotal = 0;

foreach (Conta c in vetConta)
{
    c.MostrarAtributos();
    saldoTotal += c.saldo;
}
Console.WriteLine($"Soma dos saldos: {saldoTotal}");