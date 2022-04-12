using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int alcool = 0;
            int gasolina = 0;
            int disel = 0;
            int tipo = 0;

            //Entrada 
            tipo = int.Parse(Console.ReadLine());


            //Processamento
            while (tipo != 4)
            {
                if(tipo == 1)
                    alcool++;

                else if(tipo == 2)
                    gasolina++;

                else if (tipo == 3)
                    disel++;

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: "+ alcool);
            Console.WriteLine("Gasolina: "+ gasolina);
            Console.WriteLine("Disel: "+ disel);
        }
    }
}