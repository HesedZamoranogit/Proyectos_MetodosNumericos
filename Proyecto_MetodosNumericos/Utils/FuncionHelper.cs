using System.Text.RegularExpressions;
using NCalc;

namespace Proyecto_MetodosNumericos.Utils
{
    public static class FuncionHelper
    {
        // Convierte el texto de la función a formato NCalc
        public static string NormalizarFuncion(string funcionTexto)
        {
            funcionTexto = Regex.Replace(funcionTexto, @"(\d)(x)", "$1*$2");
            funcionTexto = Regex.Replace(funcionTexto, @"x\^(\d+)", "Pow(x,$1)");
            funcionTexto = Regex.Replace(funcionTexto, @"(\d+)\*x\^(\d+)", "$1*Pow(x,$2)");
            funcionTexto = Regex.Replace(funcionTexto, @"(\d+)x\^(\d+)", "$1*Pow(x,$2)");
            funcionTexto = Regex.Replace(funcionTexto, @"\bsqrt\b", "Sqrt", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\babs\b", "Abs", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\bcos\b", "Cos", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\bexp\b", "Exp", RegexOptions.IgnoreCase);
            funcionTexto = Regex.Replace(funcionTexto, @"\bsin\b", "Sin", RegexOptions.IgnoreCase);
            return funcionTexto;
        }

        // Devuelve un delegado evaluador para NCalc
        public static Func<double, double> CrearFuncion(string funcionTexto)
        {
            string funcionNCalc = NormalizarFuncion(funcionTexto);
            return (x) =>
            {
                var expr = new Expression(funcionNCalc);
                expr.Parameters["x"] = x;
                var result = expr.Evaluate();
                if (result is double d) return d;
                if (result is int i) return Convert.ToDouble(i);
                throw new InvalidOperationException($"La expresión no se pudo evaluar como número. Resultado: {result} (Tipo: {result?.GetType().Name})");
            };
        }
    }
}