using System;

namespace Clases_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREA #2

            //Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
            long num;
            Console.WriteLine("Ingrese un numero para saber si es par o impar: ");
            num = Convert.ToInt64(Console.ReadLine());

            if((num % 2)==0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

            //Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.
            /*byte Mes;
            Console.WriteLine("Dame el numero del mes del año: ");
            Mes = Convert.ToByte(Console.ReadLine());
            switch (Mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Octubre");
                    break;
                case 10:
                    Console.WriteLine("Septiembre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Favor escribir un numero del 1 al 12");
                    break;
            }*/

            //TAREA #1
            //calcular el are y el perimetro de un rectangulo
            /*double altura, ancho, area, perimetro;
            Console.WriteLine("Dame la altura: ");
            altura= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el ancho: ");
            ancho= Convert.ToDouble(Console.ReadLine());
            area = altura * ancho;
            perimetro = 2*(altura + ancho);
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);*/
            //CALCULAR EL AREA Y EL PERIMETRO DE UN POLIGONO REGULAR
            /*double lados, numeroLados, perimetro;
            Console.WriteLine("Dame el lado: ");
            lados = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la cantidad de lados: ");
            numeroLados = Convert.ToDouble(Console.ReadLine());
            perimetro = numeroLados * lados;
            Console.WriteLine("El perimetro es: {0}", perimetro);*/
            //CALCULAR DE CENTIGRADOS A FAHRENHEIT
            /*double Gcelcius, Gfahrenheit;
            Console.WriteLine("Dame los grados celcius: ");
            Gcelcius = Convert.ToDouble(Console.ReadLine());
            Gfahrenheit = (Gcelcius * 1.8) + 32;
            Console.WriteLine("Los grados Fahrenheit son: {0}", Gfahrenheit);*/
        }
    }
}
