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
            int OpcOpe;

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
            Console.WriteLine("Ingrese un numero entero");
            double numeroCon = Convert.ToDouble(Console.ReadLine());
            if (numeroCon>0)
            {
                Console.WriteLine($"El numero {numeroCon} es positivo");
            }
            else
            {
                Console.WriteLine($"El numero {numeroCon} es negativo");
            }
            
        }

        public static void SegundoPunto()
        {
            
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine($"El numero {num1} es mayor que {num2}");
            }
            else if (num2>num1)
            {
                Console.WriteLine($"El numero {num1} es menor que {num2}");
            }
            else
            {
                Console.WriteLine($"El numero {num1} es igual que {num2}");
            }
            
        }

        public static void TercerPunto()
        {
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercero numero");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine($"El numero es mayor {num1}");
            }
            else if (num2>num1&&num2>num3)
            {
                Console.WriteLine($"El numero es mayor {num2}");
            }
            else 
            {
                Console.WriteLine($"El numero es mayor {num3}");
            }
            separador();

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"El numero es menor {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"El numero es menor {num2}");
            }
            else
            {
                Console.WriteLine($"El numero es menor {num3}");
            }
        }

        public static void CuartoPunto()
        {
            double resul=0;
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            double circu = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("La longitud de la circunferencia es: " + circu);
            Console.WriteLine("El area del circulo es: " + area);
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
