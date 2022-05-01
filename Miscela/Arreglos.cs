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
            int OpcOpe;

            do
            {


                Console.WriteLine("Digite el número correspondiente a la tarea que desea realizar");
                Console.WriteLine(" 9. Salir");

                OpcOpe = Convert.ToInt32(Console.ReadLine());


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
