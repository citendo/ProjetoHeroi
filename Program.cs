Console.WriteLine("Digite o nome do heroi: ");
string nome  = Console.ReadLine();
bool valido = false;
int xp;

do
{
    Console.WriteLine("Digite o xp do seu heroi: ");
    xp = Int32.Parse(Console.ReadLine());

    if(xp < 0)
    {
        Console.WriteLine("Digite um valor de xp válido (Maior que zero)");
        continue;
    }

    valido = true;
}while(!valido);

switch (xp)
{
    case <= 1000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Ferro");
        break;
    case >= 1001 and <= 2000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Bronze");
        break;
    case >= 2001 and <= 5000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Prata");
        break;
    case >= 5001 and <= 7000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Ouro");
        break;
    case >= 7001 and <= 8000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Platina");
        break;
    case >= 8001 and <= 9000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Ascendente");
        break;
    case >= 9001 and <= 10000:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Imortal");
        break;
    case >= 10001:
        Console.WriteLine($"O Herói de nome {nome} está no nível de Radiante");
        break;


    default:
        Console.WriteLine("");
        break;
}