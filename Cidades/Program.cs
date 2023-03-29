using System;
using System.IO;

namespace Cidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\jgabr\Desktop\Cidades_-_Cidades.csv");

            
            
            Console.WriteLine("Qual letra deseja procurar?");
            string letra = Console.ReadLine();
            

            

            foreach (var line in lines)
            {

                string cidade = line.Split(',')[2];
                string estado = line.Split(",")[3];

             
                    if (cidade.StartsWith(letra, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Cidade: {cidade}, Estado: {estado}");
                    }
               
            }
        }
    }
}
