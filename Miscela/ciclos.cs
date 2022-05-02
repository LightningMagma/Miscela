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
            int OpcOpe = 0;

            do
            {


                Console.WriteLine("Digite el número correspondiente a la tarea que desea realizar");
                Console.WriteLine(" 1. Múltiplos de 3 existentes entre 1 y 100");
                Console.WriteLine(" 2. Números Impares entre 0 y 100");
                Console.WriteLine(" 3. Números Pares entre 1 y 100");
                Console.WriteLine(" 4. Listado de los cuadrados de los números del 1 al 30");
                Console.WriteLine(" 5. Suma de los cuadrados de los primeros cien números naturales");
                Console.WriteLine(" 6. Generador de números encontrados entre dos números ingresados por el usuario.\n¡¡¡EL PRIMER NÚMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
                Console.WriteLine(" 7. Suma de números ingresados por teclado mientras sean diferentes de 0");
                Console.WriteLine(" 9. Salir");

                
                try
                {
                    OpcOpe = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                    Console.ReadKey();
                }

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
                        Console.WriteLine("Saliendo de la sección");
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
            Console.WriteLine("Los múltiplos de 3 son: ");
            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }

        }

        public static void SegundoPunto()
        {
            Console.WriteLine("Estos son los números impares entre 0 y 100:");

            for (int i = 1; i < 100; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public static void TercerPunto()
        {
            Console.WriteLine("Estos son los números pares entre 1 y 100:");

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
            Console.WriteLine("Esta es la suma de los cuadrados de los cien primeros números naturales");
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
            Console.WriteLine("¡¡¡RECUERDE QUE EL PRIMER NÚMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
            Console.WriteLine("Ingrese el primer número");
            int num1 = 0;
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese el segundo número");
            int num2 = 0;
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine($"Los números comprendidos entre {num1} y {num2} son:");
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
                Console.WriteLine("Ingrese el número que va a sumar");
                numero = 0;
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                    Console.ReadKey();
                }
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
