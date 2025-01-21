using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {

        [TestMethod]

        public void validarMetodoIngreso()
        {

            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarIngreso(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
