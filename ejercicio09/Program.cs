using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hallar el mayor de tres numeros 

            int num1;
            int num2;
            int num3;

            int mayor;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercero número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)//num2>num1 
            {
                mayor = num1;//ejecuta cuando es verdad la condicion
            }
            else//sino
            {
                mayor = num2;//ejecuta cuando es falsa la condicion
            }



            if (mayor > num3)
            {

            }
            else
            {
                mayor = num3;//ejecuta cuando es falsa la condicion
            }

            Console.WriteLine("El numero mayor es : " + mayor);
            Console.ReadKey();

        }
    }
}
