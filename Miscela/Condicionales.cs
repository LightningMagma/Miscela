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
        Variables variables = new Variables();


        public void PrimerPunto()
        {
            Console.WriteLine("Ingrese un número entero");
           
            try
            {

                variables.Num1= Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException e)
            {

                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();

            }
            if (variables.Num1>0)
            {
                Console.WriteLine($"El número {variables.Num1} es positivo");
            }
            else
            {
                Console.WriteLine($"El número {variables.Num1} es negativo");
            }
            
        }

        public void SegundoPunto()
        {            
            try
            {
                Console.WriteLine("Ingrese el primer número");                
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");                
                variables.Num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
            if (variables.Num1> variables.Num2)
            {
                Console.WriteLine($"El número {variables.Num1} es mayor que {variables.Num2}");
            }
            else if (variables.Num2 > variables.Num1)
            {
                Console.WriteLine($"El número {variables.Num1} es menor que {variables.Num2}");
            }
            else
            {
                Console.WriteLine($"El número {variables.Num1} es igual que {variables.Num2}");
            }
            
        }

        public  void TercerPunto()
        {          
           try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.Num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercero número");
                variables.Num3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }                  
                                   
            if (variables.Num1 > variables.Num2 && variables.Num1 > variables.Num3)
            {
                Console.WriteLine($"El número es mayor {variables.Num1}");
            }
            else if (variables.Num2 > variables.Num1 && variables.Num2 > variables.Num3)
            {
                Console.WriteLine($"El número es mayor {variables.Num2}");
            }
            else 
            {
                Console.WriteLine($"El número es mayor {variables.Num3}");
            }
            separador();

            if (variables.Num1 < variables.Num2 && variables.Num1 < variables.Num3)
            {
                Console.WriteLine($"El número es menor {variables.Num1}");
            }
            else if (variables.Num2 < variables.Num1 && variables.Num2 < variables.Num3)
            {
                Console.WriteLine($"El número es menor {variables.Num2}");
            }
            else
            {
                Console.WriteLine($"El número es menor {variables.Num3}");
            }
        }

        public  void CuartoPunto()
        {
            
            try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.Num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }   
                       
            if (variables.Num1 < variables.Num2)
            {
                variables.Num3=variables.Num2 + variables.Num1;
                Console.WriteLine($"{variables.Num1} + {variables.Num2} = {variables.Num3}");
            }
            else
            {
                variables.Num3= variables.Num1 - variables.Num2;
                Console.WriteLine($"{variables.Num1} - {variables.Num2} = {variables.Num3}");
            }
            
        }

        public  void QuintoPunto()
        {
            
            try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.Num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            } 
            
           
            if (variables.Num2 !=0)
            {
                variables.Num3 = variables.Num1 / variables.Num2;
                Console.WriteLine($"{variables.Num1} / {variables.Num2} = {variables.Num3}");
            }
            else
            {
                Console.WriteLine("La división no es posible");
            }
        }

        public  void SextoPunto()
        {
           
            try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.Num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }            
           
            if (variables.Num1 <0|| variables.Num2 <0)
            {
                variables.Num3 = variables.Num1 + variables.Num2;
                Console.WriteLine($"{variables.Num1} + {variables.Num2} = {variables.Num3}");
            }
            else
            {
                variables.Num3 = variables.Num1 * variables.Num2;
                Console.WriteLine($"{variables.Num1} * {variables.Num2} = {variables.Num3}");
            }
        }

        public  void SeptimoPunto()
        {
            Console.WriteLine("Ingrese el año");
            
            try
            {
                variables.Num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }

            if (variables.Num1 % 4 == 0 && variables.Num1 % 100 != 0 || variables.Num1 % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0}\n", variables.Num1);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", variables.Num1);
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
