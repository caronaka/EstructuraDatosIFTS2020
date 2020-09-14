using System;
using System.Security.Cryptography.X509Certificates;

namespace PRACTICA1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(200+56); //tarea2
            Console.WriteLine(13 * 12); //tarea 3
            Console.WriteLine(321 - 213); // tarea 4
            Console.WriteLine((20 + 5) % 6); // tarea 5

            //tarea6

            int tarea6;
            tarea6 = 12 + 102;
            Console.WriteLine(tarea6);

            //tarea7

            int tarea7 = 200 + 1111;
            Console.WriteLine(tarea7);

            //tarea8

            int numero1 = 10;  
            int numero2 = 25;
            Console.WriteLine(numero1+numero2);

            //tarea9

            int numero1tarea9;
            int numero2tarea9;

            Console.WriteLine("Ingrese un numero: ");
            numero1tarea9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2tarea9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma es {0}",(numero1tarea9 + numero2tarea9));

            // tarea 10

            int numtarea10;

            Console.WriteLine("Ingrese un numero : ");
            numtarea10 = Convert.ToInt32(Console.ReadLine());

            if (numtarea10 % 2 == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }

            

            // tarea 11

            int numtarea11;
            int num2tarea11;

            Console.WriteLine("Ingrese un numero: ");
            numtarea11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            num2tarea11 = Convert.ToInt32(Console.ReadLine());

            if (numtarea11 > num2tarea11)
            {
                Console.WriteLine("El mayor es {0}",(numtarea11));
            }
            else
            {
                Console.WriteLine("El mayor es {0}",(num2tarea11));
            }


            

            //tarea12

            int num1tarea12;
            int num2tarea12;

            Console.WriteLine("Ingrese un numero: ");
            num1tarea12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num2tarea12 = Convert.ToInt32(Console.ReadLine());

            if (num2tarea12 != 0)
            {
                Console.WriteLine(num1tarea12 / num2tarea12);

            }

            if (num2tarea12 == 0)
            {
                Console.WriteLine("Error, no se puede dividir entre 0.");
            }

            

            //tarea13

            int num13;



            Console.WriteLine("Ingrese un numero del 1 al 5: "); 
            num13 = Convert.ToInt32(Console.ReadLine());

            switch (num13)
            {
                case 1 : Console.WriteLine("Uno");
                    break;
                case 2 : Console.WriteLine("Dos");
                    break;
                case 3 : Console.WriteLine("Tres");
                    break;
                case 4 : Console.WriteLine("Cuatro");
                    break;
                case 5: Console.WriteLine("Cinco");
                    break;
            }

            

            //tarea14

            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine(n);
                n += 1;
            }

            

            //tarea15

            int n15 = 1;

            

            do
            {
                Console.WriteLine(n15);
                n15 += 1;
            }
            while (n15 <= 10);

            


            //tarea16

            int n16;

            for (n16=1; n16<=20; n16++)
            {
                Console.WriteLine(n16);
            }
        }
    }
}
