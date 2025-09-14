using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_MetodosNumericos.Formularios.Errores;

namespace Proyectos_MetodosNumericos_Test.PruebasUnitarias
{
    [TestClass]
    public class Errores
    {
        [TestMethod]
        public void ErrorAbsoluto_ValoresPositivos_CalculaCorrectamente()
        {
            var control = new ErroresControl
            {
                ValorReal = 10.0,
                ValorAproximado = 8.0
            };

            var resultado = control.ErrorAbsoluto();

            Assert.AreEqual(2.0, resultado, 0.0001);
        }

        [TestMethod]
        public void ErrorRelativo_ValoresValidos_CalculaCorrectamente()
        {
            var control = new ErroresControl
            {
                ValorReal = 10.0,
                ValorAproximado = 8.0
            };

            var resultado = control.ErrorRelativo();

            Assert.AreEqual(20.0, resultado, 0.0001); // (|10-8|/|10|)*100 = 20
        }

        [TestMethod]
        public void ErrorRelativo_ValorRealCero_RetornaInfinity()
        {
            var control = new ErroresControl
            {
                ValorReal = 0.0,
                ValorAproximado = 8.0
            };

            var resultado = control.ErrorRelativo();

            Assert.IsTrue(double.IsInfinity(resultado) || double.IsNaN(resultado));
        }

        [TestMethod]
        public void ErrorRelativo_ValorAproximadoCero_CalculaCorrectamente()
        {
            var control = new ErroresControl
            {
                ValorReal = 10.0,
                ValorAproximado = 0.0
            };

            var resultado = control.ErrorRelativo();

            Assert.AreEqual(100.0, resultado, 0.0001); // (|10-0|/|10|)*100 = 100
        }
    }
}