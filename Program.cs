Console.Write("Valor do empréstimo: ");
double valor = double.Parse(Console.ReadLine());

Console.Write("Quantidade de parcelas: ");
int parcelas = int.Parse(Console.ReadLine());

Console.Write("Renda mensal comprovada: ");
double renda = double.Parse(Console.ReadLine());

double valorParcela = valor / parcelas;
double limite = renda * 0.3;

Console.WriteLine("Valor da parcela: R$ " + valorParcela.ToString("F2"));
Console.WriteLine("Limite de parcela (30% da renda): R$ " + limite.ToString("F2"));

if (valorParcela <= limite)
{
    Console.WriteLine("Empréstimo autorizado.");
}
else
{
    Console.WriteLine("Empréstimo negado. Parcela excede 30% da renda.");
}