using System.Security.Cryptography;

namespace Termo.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine("TERMO [5 LETRAS]");
        System.Console.WriteLine("------------------------------------");

        string[] palavras =
        {
            "AFOIS",
            "BIRRA",
            "CABRA",
            "DADOS",
            "ECHOS",
            "FAROL",
            "GOLPE",
            "HORAS",
            "IDEAL",
            "JOGOS",
            "KILOS",
            "LACOS",
            "MAGOS",
            "NAVES",
            "OLHOS",
            "PILOS",
            "QUINA",
            "RACAS",
            "SALAS",
            "TUFOS"
        };

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        //logica

        System.Console.Write("Digite uma palavra: ");
        string? palavraChutada = Console.ReadLine()?.ToUpper();

        if(palavraChutada == palavraAleatoria)
        {
            System.Console.WriteLine("Voce acertou!");
        }
        else
        {
            System.Console.WriteLine("Voce errou!");
        }

    }
}
