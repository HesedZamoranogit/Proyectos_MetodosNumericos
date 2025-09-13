using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_MetodosNumericos.Implementaciones;
using System;
using System.Collections.Generic;

namespace Proyecto_MetodosNumericos_Tests
{
    [TestClass]
    public class TabulaTests
    {
        [TestMethod]
        public void Tabular_Cuadratica_ValoresCorrectos()
        {
            // Arrange
            Func<double, double> f = x => x * x;
            double xi = 0, xf = 2, incx = 1;
            double maxY, minY;

            // Act
            var resultados = Tabula.Tabular(f, xi, xf, incx, out maxY, out minY);

            // Assert
            Assert.AreEqual(3, resultados.Count);
            Assert.AreEqual(0, resultados[0].x);
            Assert.AreEqual(0, resultados[0].y);
            Assert.AreEqual(1, resultados[1].x);
            Assert.AreEqual(1, resultados[1].y);
            Assert.AreEqual(2, resultados[2].x);
            Assert.AreEqual(4, resultados[2].y);
            Assert.AreEqual(4, maxY);
            Assert.AreEqual(0, minY);
        }
    }
}