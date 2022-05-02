using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class Arreglos
    {
        public void arreglos()
        {
            Console.WriteLine("EL PROGRAMA ESTÁ EN PROCESO. COMUNIQUESE CON EL ADMINISTRADOR");
            int OpcOpe=0;

            do
            {


                Console.WriteLine("Digite el número correspondiente a la tarea que desea realizar");
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
    }
}
