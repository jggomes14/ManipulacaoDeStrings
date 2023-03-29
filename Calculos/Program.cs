﻿namespace Calculos
{
    internal class Program
    {
        static void FuncionamentoDoCalculo(string numerosParaCalcular, int maiorProduto)
        {
            for (int i = 0; i < numerosParaCalcular.Length - 4; i++)
            {
                string recorteString = numerosParaCalcular.Substring(i, 5);
                int[] numeros = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    numeros[j] = numeros[j] = Convert.ToInt32(recorteString[j]);
                }
                int calculoDeMaiorNumero = numeros[0] * numeros[1] * numeros[2] * numeros[3] * numeros[4];
                if (calculoDeMaiorNumero > maiorProduto)
                {
                    maiorProduto = calculoDeMaiorNumero;
                }    
            }
            Console.WriteLine(maiorProduto);
        }

        static void Main(string[] args)
        {
            string numerosParaCalcular = "73167176531330624919225119674426574742355349194934\r\n96983520312774506326239578318016984801869478851843\r\n85861560789112949495459501737958331952853208805511\r\n12540698747158523863050715693290963295227443043557\r\n66896648950445244523161731856403098711121722383113\r\n62229893423380308135336276614282806444486645238749\r\n30358907296290491560440772390713810515859307960866\r\n70172427121883998797908792274921901699720888093776\r\n65727333001053367881220235421809751254540594752243\r\n52584907711670556013604839586446706324415722155397\r\n53697817977846174064955149290862569321978468622482\r\n83972241375657056057490261407972968652414535100474\r\n82166370484403199890008895243450658541227588666881\r\n16427171479924442928230863465674813919123162824586\r\n17866458359124566529476545682848912883142607690042\r\n32421902267105562632111110937054421750694165896040\r\n07198403850962455444362981230987879927244284909188\r\n84580156166097919133875499200524063689912560717606\r\n05886116467109405077541002256983155200055935729725\r\n71636269561882670428252483600823257530420752963450";
            int maiorProduto = 0;
            FuncionamentoDoCalculo(numerosParaCalcular, maiorProduto);

        }
    }
    }