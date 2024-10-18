string mes = "";
int dias = 0;

Console.Clear();
Console.WriteLine("--------------------------");
Console.WriteLine("Dias de um mês");
Console.WriteLine("--------------------------\n");

Console.Write("Informe o mês por extenso:  ");
mes = Console.ReadLine()!.ToUpper();

switch(mes)
{
    case "JANEIRO":
    case "MARÇO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
        dias = 31;
        break;
    case "FEVEREIRO":
        dias = 28;
        break;
    case "ABRIL":
    case "JUNHO":
    case "SETEMBRO":
    case "NOVEMBRO":
        dias = 30;
        break;
    
    default:
        Console.WriteLine("Mês inválido");
        Environment.Exit(0);
        break;
}

Console.WriteLine($"O mês de {mes} possui {dias} dias");

// if (dias > 0)
// {  
// Console.WriteLine($"O mês de {mes} possui {dias} dias");
// }

