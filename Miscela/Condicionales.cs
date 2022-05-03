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
        Variables variables = new Variables(0,0,0,0);


        public void PrimerPunto()
        {
            Console.WriteLine("Ingrese un número entero");
           
            try
            {

                variables.num1= Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException e)
            {

                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();

            }
            if (variables.num1>0)
            {
                Console.WriteLine($"El número {variables.num1} es positivo");
            }
            else
            {
                Console.WriteLine($"El número {variables.num1} es negativo");
            }
            
        }

        public void SegundoPunto()
        {            
            try
            {
                Console.WriteLine("Ingrese el primer número");                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");                
                variables.num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
            if (variables.num1> variables.num2)
            {
                Console.WriteLine($"El número {variables.num1} es mayor que {variables.num2}");
            }
            else if (variables.num2 > variables.num1)
            {
                Console.WriteLine($"El número {variables.num1} es menor que {variables.num2}");
            }
            else
            {
                Console.WriteLine($"El número {variables.num1} es igual que {variables.num2}");
            }
            
        }

        public  void TercerPunto()
        {          
           try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercero número");
                variables.num3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }                  
                                   
            if (variables.num1 > variables.num2 && variables.num1 > variables.num3)
            {
                Console.WriteLine($"El número es mayor {variables.num1}");
            }
            else if (variables.num2 > variables.num1 && variables.num2 > variables.num3)
            {
                Console.WriteLine($"El número es mayor {variables.num2}");
            }
            else 
            {
                Console.WriteLine($"El número es mayor {variables.num3}");
            }
            separador();

            if (variables.num1 < variables.num2 && variables.num1 < variables.num3)
            {
                Console.WriteLine($"El número es menor {variables.num1}");
            }
            else if (variables.num2 < variables.num1 && variables.num2 < variables.num3)
            {
                Console.WriteLine($"El número es menor {variables.num2}");
            }
            else
            {
                Console.WriteLine($"El número es menor {variables.num3}");
            }
        }

        public  void CuartoPunto()
        {
            
            try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }   
                       
            if (variables.num1 < variables.num2)
            {
                variables.num3=variables.num2 + variables.num1;
                Console.WriteLine($"{variables.num1} + {variables.num2} = {variables.num3}");
            }
            else
            {
                variables.num3= variables.num1 - variables.num2;
                Console.WriteLine($"{variables.num1} - {variables.num2} = {variables.num3}");
            }
            
        }

        public  void QuintoPunto()
        {
            
            try
            {
                Console.WriteLine("Ingrese el primer número");
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            } 
            
           
            if (variables.num2 !=0)
            {
                variables.num3 = variables.num1 / variables.num2;
                Console.WriteLine($"{variables.num1} / {variables.num2} = {variables.num3}");
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
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }            
           
            if (variables.num1 <0|| variables.num2 <0)
            {
                variables.num3 = variables.num1 + variables.num2;
                Console.WriteLine($"{variables.num1} + {variables.num2} = {variables.num3}");
            }
            else
            {
                variables.num3 = variables.num1 * variables.num2;
                Console.WriteLine($"{variables.num1} * {variables.num2} = {variables.num3}");
            }
        }

        public  void SeptimoPunto()
        {
            Console.WriteLine("Ingrese el año");
            
            try
            {
                variables.num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }

            if (variables.num1 % 4 == 0 && variables.num1 % 100 != 0 || variables.num1 % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0}\n", variables.num1);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0} \n", variables.num1);
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
