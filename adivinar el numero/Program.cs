using System;

namespace adivinar_el_numero
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("anote un numero random press enter para continua");
                Console.WriteLine("multiplique ese número x2 press enter para continuar");
            
            Console.WriteLine("suma 8 al resultado press enter para continuar" );
           
            Console.WriteLine("Multiplica x5 press enter para continuar");

            Console.WriteLine("ingrese el total final");

            string x = (Console.ReadLine());
            x = x.Remove(x.Length - 1);
            numero = Convert.ToInt32(x);


            numero = numero - 4;
            Console.WriteLine("el numero que pensaste es: " + numero);

            Console.ReadKey();





        }
    }
}
