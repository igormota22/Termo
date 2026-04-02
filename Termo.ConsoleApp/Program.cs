using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Termo.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
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

            string palavraSecreta = palavras[19];

            //logica

            System.Console.Write("Digite uma palavra: ");
            string? palavraChutada = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrEmpty(palavraChutada) || palavraChutada?.Length > 5 || palavraChutada?.Length < 5 || !Regex.IsMatch(palavraChutada ?? "", @"^[A-Z]+$"))
            {
                System.Console.WriteLine("Digite uma palavra valida de 5 letras(apenas letras).Pressione ENTER para tentar novamente");
                Console.ReadLine();
                continue;
            }

            for (int indiceLetra = 0; indiceLetra < palavraChutada.Length; indiceLetra++)
            {
                if (palavraChutada[indiceLetra] == palavraSecreta[indiceLetra])
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.Write(palavraChutada[indiceLetra]);
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (palavraSecreta.Contains(palavraChutada[indiceLetra]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    System.Console.Write(palavraChutada[indiceLetra]);

                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    System.Console.Write(palavraChutada[indiceLetra]);

                    Console.ForegroundColor = ConsoleColor.White;

                }

            }


            if (palavraChutada == palavraSecreta)
            {
                System.Console.WriteLine("Voce acertou!");
                break;
            }
            else
            {
                System.Console.WriteLine($"Voce errou! A palavra era: {palavraSecreta}");
                break;
            }

        }
    }

}
