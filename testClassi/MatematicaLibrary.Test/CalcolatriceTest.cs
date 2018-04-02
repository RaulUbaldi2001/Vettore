using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatematicaLibrary;

namespace MatematicaLibrary.Test
{
    [TestClass]
    public class CalcolatriceTest
    {
        [TestMethod]
        public void TestArrayOrdinamento()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] { 4, 11, 13, 22 };
            int[] vettoreOrdinato = Calcolatrice.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);
        }
        public static double Raddoppia(double num)
        {
            double resp = 0;
            return resp;
        }
        public static double SommaMonete(double[] monete)
        {
            double resp=0;
            return resp;
        }
    }
}
