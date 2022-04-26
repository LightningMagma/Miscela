using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class ClasePrincipal
    {
        static void Main (string[] args)
        {
            int opc;

            do
            {
                Console.Clear();
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine("▓       Miscelánea C#       ▓");
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine("▓Digite 1 para operadores   ▓\n▓Digite 2 para condicionales▓\n▓Digite 3 bucles            ▓\n▓Digite 4 para arreglos     ▓\n▓Digite 9 para salir        ▓");
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        {
                            Operadores();
                        }
                        break;

                    case 2:
                        {
                            //Condicionales();
                        }
                        break;

                    case 3:
                        {
                            //Bucles();
                        }
                        break;

                    case 4:
                        {
                           // Arreglos();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Saliendo del programa");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Opción no válida");
                        }
                        break;
                }

                
            } while (opc != 9);
            Console.ReadKey();
        }

        static void Operadores()
        {
            int OpcOpe;

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

        static void PrimerPunto()
        {
            double resul;
            Console.WriteLine("Ingrese la base del triangulo");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            double alt = Convert.ToDouble(Console.ReadLine());
            resul = (bas * alt) / 2;
            Console.WriteLine("El resultado es:"+resul);
        }

        static void SegundoPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            resul = num1 + num2;
            Console.WriteLine("El resultado es:" + resul);
        }

        static void TercerPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            resul = num1*num1;
            Console.WriteLine("El resultado es:" + resul);
        }

        static void CuartoPunto()
        {
            double resul;
            Console.WriteLine("Ingrese el numero de euros que desea convertir");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            resul = valor1 * 0.94;
            Console.WriteLine("Euros = €" + valor1 +" Equivalen a $" +resul+" Dolares");
        }

        static void QuintoPunto()
        {
            double resul1, resul2;
            Console.WriteLine("Ingrese un lado del cuadrado");
            double lad = Convert.ToDouble(Console.ReadLine());
            resul1 = Math.Pow(lad,2);
            resul2 = lad * 4;
            Console.WriteLine("El area del cuadrado es: "+resul1);
            Console.WriteLine("El perimetro del cuadrado es: "+resul2);
        }

        static void SextoPunto()
        {
            double area, vol;
            Console.WriteLine("Ingrese el radio del cilindro");
            double rad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro");
            double altura = Convert.ToDouble(Console.ReadLine());
            vol = Math.PI * Math.Pow(rad, 2)*altura;
            area = (2*(Math.PI)*rad*altura) + (2*(Math.PI)*Math.Pow(rad,2));
            Console.WriteLine("El volumen del cilindro es: " + vol);
            Console.WriteLine("El area del cilindro es: " + area);
        }

        static void SeptimoPunto()
        {
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            double circu = 2*Math.PI*radio;
            double area  = Math.PI*Math.Pow(radio, 2);
            Console.WriteLine("La longitud de la circunferencia es: " + circu);
            Console.WriteLine("El area del circulo es: " + area);
        }

        static void OctavoPunto()
        {
            double resul1;
            Console.WriteLine("Ingrese el primer numero");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            double numero3 = Convert.ToDouble(Console.ReadLine());
            resul1 = (numero1+numero2+numero3)/3;
            Console.WriteLine("El promedio de los tres numeros es: " + resul1);
        }
        static void separador()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("^");
            }
            Console.WriteLine("\n");
        }

    }
}
