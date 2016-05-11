using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;

namespace UnitTests
{
   
    [TestClass]
    public class TestTopništva
    {
        int[] duljineBrodova = { 1, 2, 3 };
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaJeNapipavanje()
        {
            Topništvo t = new Topništvo(10, 10, duljineBrodova);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }
    }
}
[TestMethod]
public void Topništvo_NapipavanjeDajeBilokojePoljeNaPraznojMreži()
{
    Topništvo t = new Topništvo(10, 10, duljineBrodova);
    Assert.IsTrue(new Mreža(10, 10).DajSlobodnaPolja().Contains(t.UputiPucanj()));

}