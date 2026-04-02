using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace Termo.ConsoleApp;

static class Jogo
{
    static string palavraSecreta = "";
    private static void SortearPalavraSecreta()
    {
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
        palavraSecreta = palavras[indiceAleatorio];
    }

    public static void CompararPalavras()
    {
        SortearPalavraSecreta();
        int tentativas = 5;
        while (tentativas != 0)
        {
            System.Console.WriteLine($"Tentativas: {tentativas}");
            System.Console.Write(">");
            string? palavraChutada = Console.ReadLine()?.ToUpper();

            if (string.IsNullOrEmpty(palavraChutada) || palavraChutada?.Length != 5 || !Regex.IsMatch(palavraChutada ?? "", @"^[A-Z]+$"))
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

            Console.ReadLine();

            if (palavraChutada == palavraSecreta)
            {
                System.Console.WriteLine("Voce acertou!");
                break;
            }
            else
            {
                tentativas--;
                continue;
            }
        }

        System.Console.WriteLine($"Voce perdeu! A palavra era: {palavraSecreta} ");
    }
}


