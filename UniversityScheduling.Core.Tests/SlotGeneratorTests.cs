using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversityScheduling.Core.Helpers;

namespace UniversityScheduling.Core.Tests
{
    [TestClass]
    public class SlotGeneratorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            SlotsGenerator generator = new SlotsGenerator(TimeSpan.FromMinutes(50));

            var slots = generator.GetSlots();
        }
    }
}
