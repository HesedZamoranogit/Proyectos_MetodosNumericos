using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MetodosNumericos.Implementaciones
{
    public class Iteraciones_Secante
    {
        public int Numero { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Xr { get; set; }
        public double Fx1 { get; set; }
        public double Fx2 { get; set; }
        public double Fxr { get; set; }
        public double Ea { get; set; }
    }
}
