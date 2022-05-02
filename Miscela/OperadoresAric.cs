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


                Console.WriteLine("Digite la operacion que desea realizar");
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

        public static void PrimerPunto()
        {
            double resul;
            Console.WriteLine("Ingrese la base del triangulo");
            double bas = 0;
            try
            {
                bas = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese la altura del triangulo");
            double alt = 0;
            try
            {
                alt = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul = (bas * alt) / 2;
            Console.WriteLine("El resultado es:" + resul);
        }

        public static void SegundoPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el primer número");
            double num1 = 0;
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese el segundo número");
            double num2 = 0;
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul = num1 + num2;
            Console.WriteLine("El resultado es:" + resul);
        }

        public static void TercerPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el número");
            double num1 = 0;
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul = num1 * num1;
            Console.WriteLine("El resultado es:" + resul);
        }

        public static void CuartoPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el número de euros que desea convertir");
            double valor1 = 0;
            try
            {
                valor1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul = valor1 * 0.94;
            Console.WriteLine("Euros = €" + valor1 + " Equivalen a $" + resul + " Dolares");            
        }

        public static void QuintoPunto()
        {
            double resul1, resul2;
            Console.WriteLine("Ingrese un lado del cuadrado");
            double lad = 0;
            try
            {
                lad = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul1 = Math.Pow(lad, 2);
            resul2 = lad * 4;
            Console.WriteLine("El area del cuadrado es: " + resul1);
            Console.WriteLine("El perimetro del cuadrado es: " + resul2);
        }

        public static void SextoPunto()
        {
            double area, vol;
            Console.WriteLine("Ingrese el radio del cilindro");
            double rad = 0;
            try
            {
                rad = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese la altura del cilindro");
            double altura = 0;
            try
            {
                altura = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            vol = Math.PI * Math.Pow(rad, 2) * altura;
            area = (2 * (Math.PI) * rad * altura) + (2 * (Math.PI) * Math.Pow(rad, 2));
            Console.WriteLine("El volumen del cilindro es: " + vol);
            Console.WriteLine("El area del cilindro es: " + area);
        }

        public static void SeptimoPunto()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = 0;
            try
            {
                radio = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            double circu = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("La longitud de la circunferencia es: " + circu);
            Console.WriteLine("El area del circulo es: " + area);
        }

        public static void OctavoPunto()
        {
            double resul1;
            Console.WriteLine("Ingrese el primer número");
            double numero1 = 0;
            try
            {
                numero1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese el segundo número");
            double numero2 = 0;
            try
            {
                numero2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            Console.WriteLine("Ingrese el tercer número");
            double numero3 = 0;
            try
            {
                numero3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                Console.ReadKey();
            }
            resul1 = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("El promedio de los tres numeros es: " + resul1);
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
