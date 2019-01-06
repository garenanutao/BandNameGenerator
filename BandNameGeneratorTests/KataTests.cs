using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandNameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator.SolutionTest
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void BandNameGeneratorSampleTest()
        {
            Assert.AreEqual("The Knife", Kata.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", Kata.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", Kata.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", Kata.BandNameGenerator("bed"));
        }
    }
}