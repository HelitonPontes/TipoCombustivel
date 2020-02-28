using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num;
            int contA = 0;
            int contB = 0;
            int contC = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    contA++;
                }
                else if (num == 2)
                {
                    contB++;
                }
                else if (num == 3)
                {
                    contC++;
                }
            } while (num != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contA);
            Console.WriteLine("Gasolina: " + contB);
            Console.WriteLine("Diesel: " + contC);


            /*int i = 0;
            int alcool=0;
            int gasolina = 0;
            int diesel = 0;

            for (i = 1; i < 2; i = 1)
            {

                int n1 = int.Parse(Console.ReadLine());

               

                    if (n1 == 1)
                    {
                        alcool = alcool + 1;

                    }
                    else if (n1 == 2)
                    {
                        gasolina = gasolina + 1;
                    }

                    else if (n1 == 3)
                    {
                        diesel = diesel + 1;
                    }

             

                    else if (n1 == 4)
                    {
                        i = 3;
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: " + alcool);
                        Console.WriteLine("Gasolina: " + gasolina);
                        Console.WriteLine("Diesel: " + diesel);
                    }
                */
        
            Console.ReadKey();
        }
    }
}
