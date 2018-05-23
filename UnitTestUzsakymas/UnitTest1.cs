using System;
using _18_pvz_unittesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestUzsakymas
{
    [TestClass]
    public class UnitTest1Uzsakymas
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PO_SiuntaJauIssiusta_ThrowException()
        {
            Uzsakymas uzsakymas = new Uzsakymas(
                new Siuntimas(false));
            uzsakymas.PO();

        }
        [TestMethod]
        public void PO_SiuntaDarNeissiusta_Gausim4()
        {
            Uzsakymas uzsakymas = new Uzsakymas(new FakeSiunta());
            uzsakymas.PO();
            Assert.AreEqual(uzsakymas.Kaina, 24);
        }
    }
   

    class FakeSiunta : ISiuntimas
    {
        public bool IsShipped { get; }

        public int SiuntosSkaiciuotuvas()
        {
            return 4;
        }

    }

}
