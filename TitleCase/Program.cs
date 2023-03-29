using System.Globalization;

namespace TitleCase
{
    internal class Program
    {
        static void TransferirPraTitleCase ()
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine("Insira a frase aqui");
            Console.WriteLine(textInfo.ToTitleCase(Console.ReadLine()));

        }
        static void Main(string[] args)
        {
            TransferirPraTitleCase();

        }
    }
}