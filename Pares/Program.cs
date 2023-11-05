using System.ComponentModel;

Start();
void Start()
{
    restart:
    Console.WriteLine(@"

▒█▄░▒█ █░░█ █▀▄▀█ █▀▀ █▀▀█ █▀▀█ █▀▀ 　 ▒█▀▀█ █▀▀█ █▀▀█ █▀▀ █▀▀ 
▒█▒█▒█ █░░█ █░▀░█ █▀▀ █▄▄▀ █░░█ ▀▀█ 　 ▒█▄▄█ █▄▄█ █▄▄▀ █▀▀ ▀▀█ 
▒█░░▀█ ░▀▀▀ ▀░░░▀ ▀▀▀ ▀░▀▀ ▀▀▀▀ ▀▀▀ 　 ▒█░░░ ▀░░▀ ▀░▀▀ ▀▀▀ ▀▀▀
");
    TextoDinamico("Esse programa cria uma lista com 20 números, mas mostra apenas os números pares nessa lista.");
    Console.Write("\nDigite [y] para começar ou [n] para fechar o programa: ");
    string inicializador = Console.ReadLine()!;

    switch (inicializador)
    {
        case "y":
            TextoDinamico("Muito bem!");
            Thread.Sleep(1000);
            Pares();
            goto restart;
        case "n":
            Console.WriteLine("Até a próxima.");
            Thread.Sleep(1000);
            break;
        default:
            break;
    }
}
void TextoDinamico(string texto)
{
    string textoDinamico = "";
    foreach (char item in texto)
    {
        Console.Clear();
        Console.WriteLine(@"

▒█▄░▒█ █░░█ █▀▄▀█ █▀▀ █▀▀█ █▀▀█ █▀▀ 　 ▒█▀▀█ █▀▀█ █▀▀█ █▀▀ █▀▀ 
▒█▒█▒█ █░░█ █░▀░█ █▀▀ █▄▄▀ █░░█ ▀▀█ 　 ▒█▄▄█ █▄▄█ █▄▄▀ █▀▀ ▀▀█ 
▒█░░▀█ ░▀▀▀ ▀░░░▀ ▀▀▀ ▀░▀▀ ▀▀▀▀ ▀▀▀ 　 ▒█░░░ ▀░░▀ ▀░▀▀ ▀▀▀ ▀▀▀
");
        textoDinamico = textoDinamico + item.ToString();
        Console.Write(textoDinamico);
        Thread.Sleep(20);
    }
}
int Aleatorio()
{
    Random inteiroAleatorio = new Random();
    int inteiro = inteiroAleatorio.Next(1, 200);
    return inteiro;
}
void Pares()
{
    short iterador = 0;
    List<int> listaDeNumeros = new List<int>();
    do
    {
        listaDeNumeros.Add(Aleatorio());

        iterador++;

    } while (iterador < 20);

    Console.WriteLine("Com o for:\n");

    string paresComFor = "";

    for (int contador = 0; contador < listaDeNumeros.Count(); contador++)
    {
        if (listaDeNumeros[contador] % 2 == 0)
        {
            paresComFor += $"{listaDeNumeros[contador]} ";
        }
    }
    Console.WriteLine(paresComFor);

    Console.WriteLine("\nCom foreach:\n");

    string paresComForeach = "";

    foreach (int item in listaDeNumeros)
    {
        if (item % 2 == 0)
        {
            paresComForeach += $"{item} ";
        }
    }
    Console.WriteLine(paresComForeach);

    Thread.Sleep(1000);
    Console.Write("Pressione qualquer botão para voltar para o menu inicial: ");
    Console.ReadKey();
}