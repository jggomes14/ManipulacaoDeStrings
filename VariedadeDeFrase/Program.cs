using System.Diagnostics;

namespace VariedadeDeFrase
{
    internal class Program
    {
        static void TrazerAFraseEmMaiusculo(string frase)
        {
            string fraseMaiuscula = frase.ToUpper();
            Console.WriteLine(fraseMaiuscula);

        }
        static void TrazerAFraseEmMinusculo(string frase)
        {
            string fraseMiniscula = frase.ToLower();
            Console.WriteLine(fraseMiniscula);
        }
        static void TrazerAQuantidadeDeCaracteres(string frase)
        {
            int quantidadeDeCaracteres = frase.Length;
            Console.WriteLine(quantidadeDeCaracteres);
        }
        static void TrazerAPrimeiraEAUltimaPalavra (string frase)
        {
            string[] fraseSeparada = frase.Split();
            int quantidadeDePalavras = fraseSeparada.Length;
            if (quantidadeDePalavras > 0)
            {
                string primeiraPalavra = fraseSeparada[0];
                string ultimaPalavra = fraseSeparada[quantidadeDePalavras - 1];
                Console.WriteLine(primeiraPalavra);
                Console.WriteLine(ultimaPalavra);

            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insira aqui a sua frase");
            string frase = Console.ReadLine();
            TrazerAFraseEmMaiusculo(frase);
            TrazerAFraseEmMinusculo(frase);
            TrazerAQuantidadeDeCaracteres(frase);
            TrazerAPrimeiraEAUltimaPalavra(frase);


        }
    }
}