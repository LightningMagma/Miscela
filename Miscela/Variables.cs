using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscela
{
    public class Variables
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;

        public Variables()
        {
        }

        public Variables(double num1, double num2, double num3 , double num4)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
        }

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }
        public double Num3 { get => num3; set => num3 = value; }
        public double Num4 { get => num4; set => num4 = value; }
    }
}
