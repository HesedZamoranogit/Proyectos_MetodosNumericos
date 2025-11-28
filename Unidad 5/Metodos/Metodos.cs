using System;
using System.Collections.Generic;
using System.Linq;

namespace Unidad_5.Metodos
{
    internal class Metodos
    {
        // General Lagrange polynomial evaluation for n points
        public double LagrangeEvaluate((double x, double y)[] pts, double xq)
        {
            if (pts == null || pts.Length == 0) throw new ArgumentException("No hay puntos");
            // Validar x distintos
            for (int i = 0; i < pts.Length; i++)
                for (int j = i + 1; j < pts.Length; j++)
                    if (Math.Abs(pts[i].x - pts[j].x) < 1e-15)
                        throw new ArgumentException("Existen valores de X repetidos.");

            double sum = 0.0;
            for (int i = 0; i < pts.Length; i++)
            {
                double li = 1.0;
                for (int j = 0; j < pts.Length; j++)
                {
                    if (i == j) continue;
                    li *= (xq - pts[j].x) / (pts[i].x - pts[j].x);
                }
                sum += pts[i].y * li;
            }
            return sum;
        }

        public double InterpolacionLineal((double x, double y)[] pts2, double xq)
        {
            if (pts2.Length < 2) throw new ArgumentException("Se requieren 2 puntos para interpolación lineal.");
            return LagrangeEvaluate(pts2.Take(2).ToArray(), xq);
        }

        public double InterpolacionCuadratica((double x, double y)[] pts3, double xq)
        {
            if (pts3.Length < 3) throw new ArgumentException("Se requieren 3 puntos para interpolación cuadrática.");
            return LagrangeEvaluate(pts3.Take(3).ToArray(), xq);
        }

        public double InterpolacionCubica((double x, double y)[] pts4, double xq)
        {
            if (pts4.Length < 4) throw new ArgumentException("Se requieren 4 puntos para interpolación cúbica.");
            return LagrangeEvaluate(pts4.Take(4).ToArray(), xq);
        }
    }
}
