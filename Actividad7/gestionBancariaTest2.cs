using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Actividad7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void realizarIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 1;
            double saldoActual = 0;
            double saldoEsperado = 1001;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarIngreso(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        public void realizarIngreso2()
        {
            double saldoInicial = 1000;
            double ingreso = -1;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarIngreso(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        public void realizarReintegro()
        {
            double saldoInicial = 1000;
            double ingreso = 1;
            double saldoActual = 0;
            double saldoEsperado = 999;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarIngreso(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        public void realizarReintegro2()
        {
            double saldoInicial = 1000;
            double ingreso = -1;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarIngreso(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
    }
}
