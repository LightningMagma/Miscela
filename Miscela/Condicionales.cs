using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class Condicionales
    {
        public void condicionales()
        {
            int OpcOpe=0;

            do
            {


                Console.WriteLine("Digite el número correspondiente a la tarea que desea realizar");
                Console.WriteLine(" 1. Saber si el número es positivo o negativo");
                Console.WriteLine(" 2. Identificar entre dos números cuál es mayor y cuál es menor");
                Console.WriteLine(" 3. Identificar entre tres números positivos el mayor y menor");
                Console.WriteLine(" 4. Sumar o restar dos números dependiendo de cuál sea el mayor");
                Console.WriteLine(" 5. División entre dos números");
                Console.WriteLine(" 6. Sumar dos números si uno de ellos es negativo, de lo contrario, multiplicar");
                Console.WriteLine(" 7. Determinar si un año es bisiesto");
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
            Console.WriteLine("Ingrese un número entero");
            double numeroCon = 0;
            try
            {
                numeroCon = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            if (numeroCon>0)
            {
                Console.WriteLine($"El número {numeroCon} es positivo");
            }
            else
            {
                Console.WriteLine($"El número {numeroCon} es negativo");
            }
            
        }

        public static void SegundoPunto()
        {
            double num1 = 0;
            double num2 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");                
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");                
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
            if (num1>num2)
            {
                Console.WriteLine($"El número {num1} es mayor que {num2}");
            }
            else if (num2>num1)
            {
                Console.WriteLine($"El número {num1} es menor que {num2}");
            }
            else
            {
                Console.WriteLine($"El número {num1} es igual que {num2}");
            }
            
        }

        public static void TercerPunto()
        {
            
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercero número");
                num3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }                  
                                   
            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine($"El número es mayor {num1}");
            }
            else if (num2>num1&&num2>num3)
            {
                Console.WriteLine($"El número es mayor {num2}");
            }
            else 
            {
                Console.WriteLine($"El número es mayor {num3}");
            }
            separador();

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"El número es menor {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"El número es menor {num2}");
            }
            else
            {
                Console.WriteLine($"El número es menor {num3}");
            }
        }

        public static void CuartoPunto()
        {
            double resul=0;
            double num2 = 0;
            double num1 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }   
                       
            if (num1<num2)
            {
                resul = num2 + num1;
                Console.WriteLine($"{num1} + {num2} = {resul}");
            }
            else
            {
                resul=num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {resul}");
            }
            
        }

        public static void QuintoPunto()
        {
            double resul = 0;
            double num2 = 0;
            double num1 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            } 
            
           
            if (num2!=0)
            {
                resul = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {resul}");
            }
            else
            {
                Console.WriteLine("La división no es posible");
            }
        }

        public static void SextoPunto()
        {
            double resul = 0;
            double num2 = 0;
            double num1 = 0;
            try
            {
                Console.WriteLine("Ingrese el primer número");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }            
           
            if (num1<0||num2<0)
            {
                resul = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {resul}");
            }
            else
            {
                resul = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {resul}");
            }
        }

        public static void SeptimoPunto()
        {
            Console.WriteLine("Ingrese el año");
            double anio = 0;
            try
            {
                anio = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }

            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0}\n", anio);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", anio);
            }
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
