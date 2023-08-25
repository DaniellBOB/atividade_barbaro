using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Atividade 1\n");

            int i_nro1 =0, i_nro2 =0;

            Console.WriteLine("digite o 1º numero inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o 2º numero inteiro: ");
            i_nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0}",i_nro1 + i_nro2);
            Console.ReadLine();



            Console.WriteLine("Atividade 2\n");

            double d_nro1 = 0;

            Console.WriteLine("digite o numero real: ");
            d_nro1 = double.Parse(Console.ReadLine());

            Console.WriteLine("A terça parte é {0}", d_nro1 / 3);
            Console.ReadLine();

            Console.WriteLine("Atividade 3\n");
            
             d_nro1 = 0;
            double d_nro2 = 0;

            Console.Write("digite o numero real");
            d_nro1=  double.Parse(Console.ReadLine());
            Console.Write("digite o 2 numero real");
            d_nro2 = double.Parse(Console.ReadLine());


            Console.Write("MEDIA: {0}", (d_nro1 + d_nro2) / 2);

            Console.ReadLine();

            */

            Console.WriteLine("Atividade 4\n");

            double d_sal = 0;// Aplica um reajuste de 1%

            Console.Write("digite o Saldo: R$ ");
            d_sal = double.Parse(Console.ReadLine());
            
            Console.Write("O saldo com 1% a mais é {0:c}", d_sal * 1.01);
            Console.ReadLine();






            Console.WriteLine("Atividade 5\n");
            double d_nota = 0;



            Console.Write("digite a Nota da prova1: ");
            double prova1 = -Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a Nota da prova2: ");
            double notaProva2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a Nota da prova3: ");
            double notaProva3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a Nota da prova4: ");
            double notaProva4 = Convert.ToDouble(Console.ReadLine());
            double media = (prova1 + notaProva2 + notaProva3 + notaProva4);

            Console.WriteLine(media.ToString("f2"));




            Console.Write("Digite um número inteiro para a tabuada: ");


            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {


                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }










        }
    }
    }