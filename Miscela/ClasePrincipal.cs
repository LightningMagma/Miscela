using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class ClasePrincipal
    {
        static void Main(string[] args)
        {
            int opc=0;
            OperadoresAric operadores = new OperadoresAric();
            Condicionales condicionales = new Condicionales();
            ciclos Ciclos= new ciclos();
            Arreglos arreglos = new Arreglos();
            do
            {
                Console.Clear();
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine("▓       Miscelánea C#       ▓");
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.WriteLine("▓Digite 1 para operadores   ▓\n▓Digite 2 para condicionales▓\n▓Digite 3 para ciclos       ▓\n▓Digite 4 para arreglos     ▓\n▓Digite 9 para salir        ▓");
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                  
                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("El valor ingresado no es válido.\nIngrese un valor de tipo numérico", e);
                        Console.ReadKey();
                    }


                    switch (opc)
                {
                    case 1:
                        {
                            operadores.Operadores();
                        }
                        break;

                    case 2:
                        {
                            condicionales.condicionales();
                        }
                        break;

                    case 3:
                        {
                            Ciclos.Ciclos();
                        }
                        break;

                    case 4:
                        {
                            arreglos.arreglos();
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

        
    } 

    
}
