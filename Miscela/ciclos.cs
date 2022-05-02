using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class ciclos
    {
        public void Ciclos()
        {
            int OpcOpe;

            do
            {


                Console.WriteLine("Digite el número correspondiente a la tarea que desea realizar");
                Console.WriteLine(" 1. Multiplos de 3 existentes entre 1 y 100");
                Console.WriteLine(" 2. Numeros Impares entre 0 y 100");
                Console.WriteLine(" 3. Numeros Pares entre 1 y 100");
                Console.WriteLine(" 4. Listado de los cuadrados de los numeros del 1 al 30");
                Console.WriteLine(" 5. Suma de los cuadrados de los primeros cien numeros naturales");
                Console.WriteLine(" 6. Generador de numeros encontrados entre dos numeros ingresados por el usuario.\n¡¡¡EL PRIMER NUMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
                Console.WriteLine(" 7. Suma de numeros ingresados por teclado mientras sean diferentes de 0");
                Console.WriteLine(" 9. Salir");

                OpcOpe = Convert.ToInt32(Console.ReadLine());


                switch (OpcOpe)
                {
                    case 1:
                        separador();
                        PrimerPunto();
                        separador();

                        break;
                    case 2:
                        separador();
                        SegundoPunto();
                        separador();
                        break;
                    case 3:
                        separador();
                        TercerPunto();
                        separador();
                        break;
                    case 4:
                        separador();
                        CuartoPunto();
                        separador();
                        break;
                    case 5:
                        separador();
                        QuintoPunto();
                        separador();
                        break;
                    case 6:
                        separador();
                        SextoPunto();
                        separador();
                        break;
                    case 7:
                        separador();
                        SeptimoPunto();
                        separador();
                        break;

                    case 9:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        {
                            Console.WriteLine("Opcion no válida");
                        }
                        break;
                }

            } while (OpcOpe != 9);

            Console.ReadKey();
        }

        public static void PrimerPunto()
        {
            Console.WriteLine("Los multiplos de 3 son: ");
            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }

        }

        public static void SegundoPunto()
        {
            Console.WriteLine("Estos son los numeros impares entre 0 y 100:");

            for (int i = 1; i < 100; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public static void TercerPunto()
        {
            Console.WriteLine("Estos son los numeros pares entre 1 y 100:");

            for (int i = 2; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void CuartoPunto()
        {
            Console.WriteLine("Estos son los cuadrados de los números del uno al treinta:");

            for (int i = 1; i <= 30; i++)
            {
                int cuadrados = (int) Math.Pow(i, 2);
                Console.WriteLine($"El cuadrado de {i} es {cuadrados}");
            }
        }

        public static void QuintoPunto()
        {
            Console.WriteLine("Esta es la suma de los cuadrados de los cien primeros numeros naturales");
            int suma=0;
            for (int i = 1; i <= 100; i ++)
            {
                int cuadrado = (int) Math.Pow(i,2);
                suma = suma + cuadrado;
                Console.WriteLine($"El cuadrado de {i} es {cuadrado}");
            }
            Console.WriteLine($"El resultado de la suma es {suma}");
        }

        public static void SextoPunto()
        {
            Console.WriteLine("¡¡¡RECUERDE QUE EL PRIMER NUMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Los numeros comprendidos entre {num1} y {num2} son:");
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void SeptimoPunto()
        {
            int numero,suma=0;
            do
            {
                Console.WriteLine("Ingrese el numero que va a sumar");
                numero = Convert.ToInt32(Console.ReadLine());
                suma = suma + numero;
                Console.WriteLine($"La suma hasta el momento es: {suma}");
            } while (numero!=0);
        }

        public static void separador()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("^");
            }
            Console.WriteLine("\n");
        }
    }
}
