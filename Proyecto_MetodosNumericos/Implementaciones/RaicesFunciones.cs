using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AngouriMath.MathS;

namespace Proyecto_MetodosNumericos.Implementaciones
{
    public class RaicesFunciones
    {
        public int Iteraciones { get; set; }
        public List<Iteraciones_Bisecc> Biseccion(
           Func<double, double> f,
           double xi,
           double xf, //Parametros de los valores de entrada
           double eamax)
        {

            var listaIteraciones = new List<Iteraciones_Bisecc>(); //Con esto guardamos las iteraciones


            Iteraciones = 0;
            double xr = 0;
            double ea = 100; //Error inicial alto para entrar al ciclo


            if (f(xi) * f(xf) >= 0)
            {
                MessageBox.Show(
                    "Error: No hay cambio de signo en el intervalo. \nVerifica xi y xf.",
                    "Error de intervalo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return new List<Iteraciones_Bisecc>(); // Retorna lista vacía y no detiene el sistema
            }






            while (ea > eamax)
                {
                double xrsave = xr; //Ira guardando el valor de Xr anterior
                xr = (xi + xf) / 2; //Sacar la xr

                double fxr = f(xr);
                double fxi = f(xi); //Ahora evaluamos la funcion sustituyendo las Xi y las Xf
                double fxf = f(xf);

                if (Iteraciones > 0) //No sale error en la primera iteracion hasta que 
                                     //Se tengan dos iteraciones 0 y 1
                {
                    ea = Math.Abs((xr - xrsave) / xr) * 100; // error aproximado
                }

                // Determinar en qué subintervalo continuar
                double fxiFxr = fxi * fxr;

                if (fxiFxr < 0)
                {
                    xf = xr;
                }
                else if (fxiFxr > 0)
                {
                    xi = xr;
                }
                else
                {
                    ea = 0; // Raíz exacta encontrada
                }

                // Guardar en lista
                listaIteraciones.Add(new Iteraciones_Bisecc
                {
                    Numero = Iteraciones + 1,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    Fxi = fxi,
                    Fxr = fxr,
                    FxiFxr = fxiFxr,
                    Ea = ea,



                });

                Iteraciones++;
            }

            return listaIteraciones;
        }

        // Método para la Regla Falsa
        public List<Iteraciones_RFalsa> ReglaFalsa(
            Func<double, double> f,
            double xi,
            double xf,
            double eamax)
        {
            var listaIteraciones = new List<Iteraciones_RFalsa>();
            Iteraciones = 0;
            double xr = 0;
            double ea = 100;

            if (f(xi) * f(xf) >= 0)
            {
                MessageBox.Show(
                    "Error: No hay cambio de signo en el intervalo. \nVerifica xi y xf.",
                    "Error de intervalo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return new List<Iteraciones_RFalsa>(); // Retorna lista vacía y no detiene el sistema
            }

            while (ea > eamax)
            {
                double xrsave = xr;
                double fxi = f(xi);
                double fxf = f(xf);

                // Fórmula de la Regla Falsa
                xr = xf - (fxf * (xi - xf)) / (fxi - fxf);

                double fxr = f(xr);

                if (Iteraciones > 0)
                {
                    ea = Math.Abs((xr - xrsave) / xr) * 100;
                }

                double fxiFxr = fxi * fxr;

                if (fxiFxr < 0)
                {
                    xf = xr;
                }
                else if (fxiFxr > 0)
                {
                    xi = xr;
                }
                else
                {
                    ea = 0;
                }

                listaIteraciones.Add(new Iteraciones_RFalsa
                {
                    Numero = Iteraciones + 1,
                    Xi = xi,
                    Xf = xf,
                    Fxi = fxi,
                    Fxf = fxf,
                    Xr = xr,
                    Fxr = fxr,
                    FxiFxr = fxiFxr,
                    Ea = ea,
                });

                Iteraciones++;
            }

            return listaIteraciones;
        }

        public List<Iteraciones_Newton> NewtonRaphson(
            Func<double, double> f,
            double xi,
            double eamax)
        {
            // Implementación del método de Newton-Raphson
            var listaIteraciones = new List<Iteraciones_Newton>();
            Iteraciones = 0;
            double xr = xi;
            double ea = 100;

            while (ea > eamax)
            {
                double fxr = f(xr);
                double dfxr = Derivada(f, xr); // Calcula la derivada numérica en xr

                if (dfxr == 0)
                    throw new ArgumentException("La derivada es cero. Método fallido en la iteración " + Iteraciones);

                double xrsave = xr;
                // Fórmula de Newton-Raphson
                xr = xr - fxr / dfxr;

                if (Iteraciones > 0)
                {
                    ea = Math.Abs((xr - xrsave) / xr) * 100;
                }

                listaIteraciones.Add(new Iteraciones_Newton
                {
                    Numero = Iteraciones + 1,
                    Xi = xr,
                    Fxi = fxr,
                    Ea = ea,
                });

                Iteraciones++;
            }

            return listaIteraciones;
        }

        public List<Iteraciones_Secante> Secante(
            Func<double, double> f,
            double x1,
            double x2,
            double eamax
        )
        {
            var listaIteraciones = new List<Iteraciones_Secante>();
            Iteraciones = 0;
            double ea = 100;
            double xr = 0, fx1, fx2, fxr;

            while (ea > eamax)
            {
                fx1 = f(x1);
                fx2 = f(x2);

                // Fórmula del método de la secante
                xr = x2 - (fx2 * (x1 - x2)) / (fx1 - fx2);
                fxr = f(xr);

                if (Iteraciones > 0)
                {
                    ea = Math.Abs((xr - x2) / xr) * 100;
                }

                listaIteraciones.Add(new Iteraciones_Secante
                {
                    Numero = Iteraciones + 1,
                    X1 = x1,
                    X2 = x2,
                    Xr = xr,
                    Fx1 = fx1,
                    Fx2 = fx2,
                    Fxr = fxr,
                    Ea = ea,
                });

                // Actualizar puntos para la siguiente iteración
                x1 = x2;
                x2 = xr;
                Iteraciones++;
            }
            return listaIteraciones;
        }

        // Método para calcular la derivada numérica
        private double Derivada(Func<double, double> f, double x)
        {
            double h = 1e-10; // Paso pequeño
            return (f(x + h) - f(x - h)) / (2 * h);
        }

    }
}