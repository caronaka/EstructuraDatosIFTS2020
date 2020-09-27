using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // si o si hay que incluir esta referencia para trabajar con cola y pila

namespace CLASE6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            // PILA L.I.F.O. Last In First Out

            string palabra;
            Stack miPila = new Stack(); //stack seria pila
            miPila.Push("Hola, "); //push es agregar, pop es sacar
            miPila.Push("soy");
            miPila.Push("yo");

            for (byte i=0; i<3; i++)
            {
                palabra = (string)miPila.Pop(); //en cada uno de los 3 ciclos guardas el contenido que va sacando en palabra y vas imprimiendo
                Console.WriteLine(palabra);
            }
            Console.ReadKey();


            // COLA F.I.F.O First In Last Out


            string palabra2;

            Queue miCola = new Queue(); //queue seria cola
            miCola.Enqueue("Hola, "); //enqueue es encolar, dequeue es desencolar
            miCola.Enqueue("soy");
            miCola.Enqueue("yo");

            for (byte i = 0; i < 3; i++)
            {
                palabra2 = (string)miCola.Dequeue(); //en cada uno de los 3 ciclos guardas el contenido que va sacando/desencolando en palabra y vas imprimiendo
                Console.WriteLine(palabra2);
            }
            Console.ReadKey();

            */




            //TAREA1


            /*

            int numero;
            int vuelta = 0;
            int resultado;

            Stack pilaNum = new Stack();

            while (vuelta != 6)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                pilaNum.Push(numero);
                vuelta++;
            }


            for (byte i = 0; i < 6; i++)
            {
                resultado = (int)pilaNum.Pop(); 
                Console.WriteLine(resultado);
            }
            Console.ReadKey();

            */


            /*


            //TAREA 2

            double numero;
            int vuelta = 0;
            double resultado;

            Queue colaNum = new Queue();

            while (vuelta != 6)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Convert.ToDouble(Console.ReadLine());
                colaNum.Enqueue(numero);
                vuelta++;
            }


            for (byte i = 0; i < 6; i++)
            {
                resultado = (double)colaNum.Dequeue();
                Console.WriteLine(resultado);
            }
            Console.ReadKey();

            */


            //TAREA 3

            /*

            string frase;
            int vuelta = 0;
            string resultado;



            Queue colaFrase = new Queue();

            Console.WriteLine("Ingrese un frase: ");
            frase = Console.ReadLine();
            colaFrase.Enqueue(frase);

            while (frase != "" )
            {
                Console.WriteLine("Ingrese un frase: ");
                frase = Console.ReadLine();
                colaFrase.Enqueue(frase);
                
            }

            int elementosCola = colaFrase.Count;

            for (byte i = 0; i < elementosCola; i++)
            {
                resultado = (string)colaFrase.Dequeue();
                Console.WriteLine(resultado);
            }
            Console.ReadKey();


            */





        }
    }
}
