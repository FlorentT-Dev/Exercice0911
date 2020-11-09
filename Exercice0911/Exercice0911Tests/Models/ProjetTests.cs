using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice0911.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models.Tests
{
    [TestClass()]
    public class ProjetTests
    {
        [TestMethod()]
        public void pourcentageAvancementTest()
        {
            Projet p1 = new Projet(1,"Création",02/12/2020,02/14/2020,05/14/2020,06/02/2020,"Fini",);
            float result = p1.pourcentageAvancement();
            Assert.AreEqual(result, false);

        }
    }
}