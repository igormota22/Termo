using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Termo.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {

        //Console.Clear();
        ExibirCabecalho();
        Jogo.CompararPalavras();

    }

    static void ExibirCabecalho()
    {
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine("TERMO [5 LETRAS]");
        System.Console.WriteLine("------------------------------------");

    }




}


