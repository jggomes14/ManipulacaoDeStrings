namespace SepararENumerarPalavras
{
    internal class Program
    {
        static void SepararENumerarPalavras()
        {
            Console.WriteLine("Insira sua frase aqui:");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split();
            int totalPalavras = palavras.Length;

            Console.WriteLine(totalPalavras);
        }
        static void Main(string[] args)
        {
            SepararENumerarPalavras();
        }
    }
}