using Microsoft.VisualStudio.TestTools.UnitTesting;
using pesel;
using System;

namespace testp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nowyPesel = new PESELWalidator("96111002015");

            nowyPesel.WczytajPesel("96111002015");
            int[] peselTestowy = new int[] { 9, 6, 1, 1, 1, 0, 0, 2, 0, 1, 5 }; 

            
        }
        [TestMethod]
        public void DataUrodzenia()
        {
            
            var nowyPesel = new PESELWalidator("96111002015");
            nowyPesel.WczytajPesel("96111002015");
            
            string data = "10/11/1996";
            
            Assert.AreEqual(data, nowyPesel.DataUrodzenia());
        }
        [TestMethod]
        public void PlecMezczyzna()
        {
            var nowyPesel = new PESELWalidator("96111002015");
            nowyPesel.WczytajPesel("96111002015");
            string m = "M";
            Assert.AreEqual(m, nowyPesel.Plec());
        }
        [TestMethod]
        public void PlecKobieta()
        {
            var Pesel = new PESELWalidator("96111002014");
            Pesel.WczytajPesel("96111002014");
            string k = "K";
            Assert.AreEqual(k, Pesel.Plec());
        }
        [TestMethod]
        public void Sprawdzenie()
        {
            var nowyPesel = new PESELWalidator("96111002015");
            nowyPesel.WczytajPesel("96111002015");
            Assert.AreEqual(true, nowyPesel.SprawdzPesel());
            
            
        }
        
        

    }
}
