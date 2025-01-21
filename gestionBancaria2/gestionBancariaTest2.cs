using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
namespace gestionBancaria2
{
    [TestClass]
    public class gestionBancariaTest2
    {
        [TestMethod]
         

        public void realizarIngreso()
        {
            //preparacion del caso de prueba
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
        [TestMethod]
        public void realizarIngreso2()
       
        {
            //preparacion del caso de prueba
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
        [TestMethod]

        public void realizarReintegro()
        {
            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 1;
            double saldoActual = 0;
            double saldoEsperado = 999;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarReintegro(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void realizarReintegro2()
        {
            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarReintegro(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegro3()
        {
            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 10000;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarReintegro(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegro4()
        {
            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarReintegro(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarIngreso3()
        {
            //preparacion del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 10000;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            //Metodo a probar
            cuenta.realizarReintegro(ingreso);
            // afirmacion de la prueba (valor esperado Vs. valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
