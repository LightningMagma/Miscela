using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    internal class Validaciones
    {        
        private string dato;
        public string Dato { get => dato; set => dato = value; }

        public double validarDouble(double dato) {
            try
            {          
                return dato;                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Dato no valido" + e);
                
                return dato;
                
            }
        
        }
        
    }
}
