using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Tests_01_Min;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tests_01_Min.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = [1, 4, 18, -7, 31];
            Assert.AreEqual(-7, Tools.FindMin(nums));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMinTestEmptyInput()
        {
            int[] nums = [];
            Tools.FindMin(nums);
            Assert.Fail();
        }
    }
}