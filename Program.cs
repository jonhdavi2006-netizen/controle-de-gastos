decimal salario,gastoAli,gastotrans,gastolaz,total,restante;
string name;
Console.WriteLine("Digite seu nome:");
name = Console.ReadLine();

Console.WriteLine("digite o quanto voce ganha por mes:");
salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("digite o quanto voce gasta com alimentacao por mes:");
gastoAli = decimal.Parse(Console.ReadLine());

Console.WriteLine("digite o quanto voce gasta com transporte por mes:");
gastotrans = decimal.Parse(Console.ReadLine());

Console.WriteLine("digite o quanto voce gasta com lazer por mes:");
gastolaz = decimal.Parse(Console.ReadLine());

total = gastoAli + gastotrans + gastolaz;
restante = salario - total;

if (restante < 0)
{
    Console.WriteLine("voce esta gastando demais");
    Console.WriteLine($"voce esta devendo esse valor para o mes que vem:{Math.Abs(restante)}");
}
else if (restante > 0)
{
    Console.WriteLine("voce esta gastando o suficiente");
    Console.WriteLine($"sobrou por mês o valor de: R${restante}");
}
else
{
    Console.WriteLine("voce esta gastando exatamente o que ganha");
    Console.WriteLine($"sobrou por mês o valor de: R${restante}");
}


