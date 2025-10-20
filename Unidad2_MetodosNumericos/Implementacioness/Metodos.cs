using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_MetodosNumericos.Implementacioness
{
    public class Metodos
    {

        public double[] EliminacionGauss(double[,] a)
        {
            int n = a.GetLength(0);
            EliminacionAdelante(a);
            return SustitucionAtras(a, new double[n]);
        }

        public void EliminacionAdelante(double[,] a)
        {
            int n = a.GetLength(0);

            for (int i = 0; i < n - 1; i++)
            {
                Pivotea(a, i);

                for (int k = i + 1; k < n; k++)
                {
                    double factor = a[k, i] / a[i, i];
                    for (int j = i; j < n + 1; j++)
                    {
                        a[k, j] = a[k, j] - factor * a[i, j];
                    }
                }
            }
        }

        public void Pivotea(double[,] a, int i)
        {
            int n = a.GetLength(0);
            int maxFila = i;
            double maxValor = Math.Abs(a[i, i]);

            for (int k = i + 1; k < n; k++)
            {
                if (Math.Abs(a[k, i]) > maxValor)
                {
                    maxValor = Math.Abs(a[k, i]);
                    maxFila = k;
                }
            }

            if (maxFila != i)
            {
                for (int j = 0; j <= n; j++)
                {
                    double temp = a[i, j];
                    a[i, j] = a[maxFila, j];
                    a[maxFila, j] = temp;
                }
            }
        }

        public double[] SustitucionAtras(double[,] a, double[] x)
        {
            int n = a.GetLength(0);

            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += a[i, j] * x[j];
                }

                x[i] = (a[i, n] - suma) / a[i, i];
            }

            return x;
        }

        public double[] GaussJordan(double[,] a)
        {
            int n = a.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                Pivotea(a, i);

                double pivote = a[i, i];

                for (int j = 0; j <= n; j++)
                {
                    a[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = a[k, i];
                        for (int j = 0; j <= n; j++)
                            a[k, j] -= factor * a[i, j];
                    }
                }
            }

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = a[i, n];

            return x;
        }

        public double[] GaussSeidel(double[,] A, double[] b, int maxIter = 100, double tol = 1e-8)
        {
            int n = A.GetLength(0);
            double[] x = new double[n];
            for (int iter = 0; iter < maxIter; iter++)
            {
                double[] xOld = (double[])x.Clone();
                for (int i = 0; i < n; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            sum += A[i, j] * x[j];
                    }
                    x[i] = (b[i] - sum) / A[i, i];
                }
                // Verifica convergencia
                double error = 0;
                for (int i = 0; i < n; i++)
                    error += Math.Abs(x[i] - xOld[i]);
                if (error < tol)
                    break;
            }
            return x;
        }

        public List<GaussSeidelIteracion> GaussSeidelIterativo(double[,] A, double[] b, int maxIter = 100, double tol = 1e-3)
        {
            int n = A.GetLength(0);
            double[] x = new double[n];
            var iteraciones = new List<GaussSeidelIteracion>();

            for (int iter = 0; iter < maxIter; iter++)
            {
                double[] xOld = (double[])x.Clone();
                double[] ea = new double[n];

                for (int i = 0; i < n; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            sum += A[i, j] * x[j];
                    }
                    x[i] = (b[i] - sum) / A[i, i];

                    ea[i] = iter == 0 ? 1.0 : Math.Abs((x[i] - xOld[i]) / (x[i] != 0 ? x[i] : 1)) * 100.0;
                }

                iteraciones.Add(new GaussSeidelIteracion
                {
                    X = (double[])x.Clone(),
                    Ea = (double[])ea.Clone()
                });

                if (ea.All(e => e < tol))
                    break;
            }
            return iteraciones;
        }

        public static double[,] RandomDiagonallyDominantAugmented(int n, int min = -5, int max = 5)
        {
            if (n < 1)
                throw new ArgumentException("n debe ser > 0");
            var rnd = new Random();
            var Ab = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                double rowsum = 0.0;
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    int v = rnd.Next(min, max + 1);
                    Ab[i, j] = v;
                    rowsum += Math.Abs(v);
                }
                // Diagonal dominante estricta
                Ab[i, i] = rowsum + rnd.Next(1, 6);
                // termino independiente
                Ab[i, n] = rnd.Next(min * 2, max * 2 + 1);
            }
            return Ab;
        }
        public class GaussSeidelIteracion
        {
            public double[] X { get; set; }
            public double[] Ea { get; set; }
        }
    }
}



