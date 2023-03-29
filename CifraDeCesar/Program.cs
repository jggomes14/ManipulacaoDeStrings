namespace CifraDeCesar
{
    internal class Program
    {
        static void CifraDeCesar()
        {
            Console.WriteLine("Insira sua palavra aqui");
            string palavras = Convert.ToString(Console.ReadLine());
            char[] msg = palavras.ToCharArray();

            Console.WriteLine("Insira o valor da alteração");
            int valorDeTroca = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < palavras.Length; i++)
            {
                Convert.ToInt32(msg[i]);
                int letra = msg[i];
                int novaLetra = letra + valorDeTroca;
                char novaMsg = Convert.ToChar(novaLetra);
                Console.WriteLine(novaMsg);

            }
        }
        static void Main(string[] args)
        {
            CifraDeCesar();
        }
    }
}