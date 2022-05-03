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
        Variables variables = new Variables(0,0,0,0);
        public  void PrimerPunto()
        {
            Console.WriteLine("Los múltiplos de 3 son: ");
            for (int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }

        }

        public  void SegundoPunto()
        {
            Console.WriteLine("Estos son los números impares entre 0 y 100:");

            for (int i = 1; i < 100; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public  void TercerPunto()
        {
            Console.WriteLine("Estos son los números pares entre 1 y 100:");

            for (int i = 2; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public  void CuartoPunto()
        {
            Console.WriteLine("Estos son los cuadrados de los números del uno al treinta:");

            for (int i = 1; i <= 30; i++)
            {
                variables.num1= (int) Math.Pow(i, 2);
                Console.WriteLine($"El cuadrado de {i} es {variables.num1}");
            }
        }

        public  void QuintoPunto()
        {
            Console.WriteLine("Esta es la suma de los cuadrados de los cien primeros números naturales");            
            for (int i = 1; i <= 100; i ++)
            {
                variables.num2 = (int) Math.Pow(i,2);
                variables.num1 = variables.num1 + variables.num2;
                Console.WriteLine($"El cuadrado de {i} es {variables.num2}");
            }
            Console.WriteLine($"El resultado de la suma es {variables.num1}");
        }

        public  void SextoPunto()
        {     
            try
            {
                Console.WriteLine("¡¡¡RECUERDE QUE EL PRIMER NÚMERO DEBE SER MENOR QUE EL SEGUNDO!!!");
                Console.WriteLine("Ingrese el primer número");
                variables.num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Los números comprendidos entre {variables.num1} y {variables.num2} son:");
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }      
            
            
            for (variables.num1=variables.num1 ; variables.num1 <= variables.num2; variables.num1++)
            {
                Console.WriteLine(variables.num1);
            }
        }

        public  void SeptimoPunto()
        {
            
            do
            {
                variables.num1 = 0;
                try
                {
                    Console.WriteLine("Ingrese el número que va a sumar");
                    variables.num1 = Convert.ToInt32(Console.ReadLine());
                    variables.num2 = variables.num2 + variables.num1;
                    Console.WriteLine($"La suma hasta el momento es: {variables.num2}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                    Console.ReadKey();
                }
                
            } while (variables.num1 !=0);
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
