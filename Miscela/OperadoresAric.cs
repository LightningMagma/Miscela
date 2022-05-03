using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class OperadoresAric
    {       

        public void Operadores()
        {
            int OpcOpe=0;

            do
            {
                Console.WriteLine("Digite la operación que desea realizar");
                Console.WriteLine(" 1. Area de un triángulo");
                Console.WriteLine(" 2. Suma de dos números");
                Console.WriteLine(" 3. Cuadrado de un número");
                Console.WriteLine(" 4. Conversión de euros a dólares");
                Console.WriteLine(" 5. Area y perimetro de un cuadrado a partir de un de sus lados");
                Console.WriteLine(" 6. Area y volumen de un cilindro");
                Console.WriteLine(" 7. Longitud y area de un circulo a partir de su radio");
                Console.WriteLine(" 8. Promedio de tres numeros");
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
                    case 8:
                        separador();
                        OctavoPunto();
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
        Variables variables = new Variables(0, 0, 0, 0);
        public void PrimerPunto()
        {
            
            try
            {                       
            Console.WriteLine("Ingrese la base del triangulo");
            variables.num1=(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Ingrese la altura del triangulo");
            variables.num2=(Convert.ToDouble(Console.ReadLine()));
            variables.num3 = (variables.num1 * variables.num2) / 2;
            Console.WriteLine("El resultado es:" + variables.num3);            

            }
            catch (FormatException ex)
            {
                Console.WriteLine( "Se esperaba un número");
            }
        }
        
        public void SegundoPunto()
        {

            try
            {               
                Console.WriteLine("Ingrese el primer número");
                variables.num1 = (Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Ingrese el segundo número");
                variables.num2 = (Convert.ToDouble(Console.ReadLine()));
                variables.num3= variables.num1 + variables.num2;
                Console.WriteLine("El resultado es:" + variables.num3);

            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
        }

        public void TercerPunto()
        {
            
            try
            {              
                Console.WriteLine("Ingrese el número");                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = variables.num1 * variables.num1;
                Console.WriteLine("El resultado es:" + variables.num2);
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
        }

        public void CuartoPunto()
        {
            
            try
            {               
                Console.WriteLine("Ingrese el número de euros que desea convertir");                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = variables.num1 * 0.94;
                Console.WriteLine("Euros = €" + variables.num1 + " Equivalen a $" + variables.num2 + " Dolares");
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
                     
        }

        public void QuintoPunto()
        {
           
            try
            {
                
                Console.WriteLine("Ingrese un lado del cuadrado");
                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2 = Math.Pow(variables.num1, 2);
                variables.num3 = variables.num1 * 4;
                Console.WriteLine("El area del cuadrado es: " + variables.num2);
                Console.WriteLine("El perimetro del cuadrado es: " + variables.num3);
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
        }

        public void SextoPunto()
        {
            
            try
            {
               
                Console.WriteLine("Ingrese el radio del cilindro");                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del cilindro");
                variables.num2 = Convert.ToDouble(Console.ReadLine());
                variables.num3 = Math.PI * Math.Pow(variables.num1, 2) * variables.num2;
                variables.num4 = (2 * (Math.PI) * variables.num1 * variables.num2) + (2 * (Math.PI) * Math.Pow(variables.num1, 2));
                Console.WriteLine("El volumen del cilindro es: " + variables.num3);
                Console.WriteLine("El area del cilindro es: " + variables.num4);
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }            
            
        }

        public void SeptimoPunto()
        {
            
            try
            {
                Console.WriteLine("Ingrese el radio del circulo");                
                variables.num1 = Convert.ToDouble(Console.ReadLine());
                variables.num2= 2 * Math.PI * variables.num1;
                variables.num3 = Math.PI * Math.Pow(variables.num1, 2);
                Console.WriteLine("La longitud de la circunferencia es: " + variables.num2);
                Console.WriteLine("El area del circulo es: " + variables.num4);
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            
        }

        public void OctavoPunto()
        {
            
            try
            {
                
                Console.WriteLine("Ingrese el primer número");                
                variables.num1= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número");                
                variables.num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número");
                variables.num3 = Convert.ToDouble(Console.ReadLine());;

                variables.num4 = (variables.num1 + variables.num2 + variables.num3) / 3;
                Console.WriteLine("El promedio de los tres numeros es: " + variables.num4);

            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
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
