using System;

namespace adivinar_el_numero
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcioon =00;

            Console.WriteLine("ingrese la opcion      1= adivinar numero     2= adivinar edades");
            opcioon = Convert.ToInt32(Console.ReadLine());

            if (opcioon == 1)
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
            else if (opcioon == 2)

            {


                Console.WriteLine("Anote el dia en que nacio press enter para continuar ");
                Console.WriteLine("Multiplique x20 el dato press enter para continuar");
                Console.WriteLine("Ahora sumale 73 press enter para continuar");
                Console.WriteLine("Ahora multiplicalo x5 press enter para continuar");
                Console.WriteLine("Sumale el numero del mes de cumpleaños press enter para continuar");
                Console.WriteLine("ingrese el total final");

                int numero = Convert.ToInt32(Console.ReadLine());
                numero = numero - 365;
                String a = Convert.ToString(numero);
                Console.WriteLine("El dia en que nacio es" + a.Substring(0, 2) + "el mes en que nacio es" + a.Substring(2, 2));

                Console.ReadKey();



            }
        }
    }
}
