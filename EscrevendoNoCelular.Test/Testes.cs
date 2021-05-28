using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EscrevendoNoCelular.ConsoleApp;

namespace EscrevendoNoCelular.Test
{
    [TestClass]
    public class Testes
    {
        TransformaQwerty transforma = new TransformaQwerty();


        [TestMethod]
        public void DeveRetornar2()
        {
            Assert.AreEqual("2", transforma.RetornaQwerty("A"));
        }
        [TestMethod]
        public void DeveRetornar3()
        {
            Assert.AreEqual("3", transforma.RetornaQwerty("D"));
        }
        [TestMethod]
        public void DeveRetornar4()
        {
            Assert.AreEqual("4", transforma.RetornaQwerty("G"));
        }
        [TestMethod]
        public void DeveRetornar5()
        {
            Assert.AreEqual("5", transforma.RetornaQwerty("J"));
        }
        [TestMethod]
        public void DeveRetornar6()
        {
            Assert.AreEqual("6", transforma.RetornaQwerty("M"));
        }
        [TestMethod]
        public void DeveRetornar7()
        {
            Assert.AreEqual("7", transforma.RetornaQwerty("P"));
        }
        [TestMethod]
        public void DeveRetornar8()
        {
            Assert.AreEqual("8", transforma.RetornaQwerty("T"));
        }
        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual("9", transforma.RetornaQwerty("W"));
        }
        [TestMethod]
        public void DeveRetornar0()
        {
            Assert.AreEqual("0", transforma.RetornaQwerty(" "));
        }
        [TestMethod]
        public void DeveRetornar5_5()
        {
            Assert.AreEqual("5_5", transforma.RetornaQwerty("JJ"));
        }
        public void DeveRetornar7777_77779()
        {
            Assert.AreEqual("7777_77779_997", transforma.RetornaQwerty("SSWXP"));
        }
        [TestMethod]
        public void DeveRetornarNumeroGigantesco()
        {
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", transforma.RetornaQwerty("SEMPRE ACESSO O DOJOPUZZLES"));
        }
    }
}
