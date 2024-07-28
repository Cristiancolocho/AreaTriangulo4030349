using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace AreaTriangulo4030349.Models
{
    internal class Triangulo 
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double CalcularArea()
        {
            double a = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(a * (a - LadoA) * (a - LadoB) * (a - LadoC));
            return area;
        }

    }
}
