using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MetodosNumericos.Implementaciones
{
    public class Tabula
    {                                                   
        public static List<(double x, double y)> Tabular(
            
            Func<double, double> f,   //Funcion Matematica

            double xi, //Valor inicial
            double xf, //El valor final

            double incx, //Incremento de cada valor de x

            out double maxY,//Variables donde se guarda el valor maximo y minimo
            out double minY
            )
        {
            List<(double x, double y)> resultados = new List<(double x, double y)>();
            maxY = double.MinValue;
            minY = double.MaxValue;

            for (double x = xi; x <= xf; x += incx)
            {
                double y = f(x);
                resultados.Add((x, y));

                if (y > maxY) maxY = y;
                if (y < minY) minY = y;
            }

            return resultados;
        }

    }
}
