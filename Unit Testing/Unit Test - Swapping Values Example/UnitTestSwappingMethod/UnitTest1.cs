using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing___Swapping_Values_Example;

namespace UnitTestSwappingMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSwappingMethod()
        {
            //Arrange 
            Swapping swapValues = new Swapping();

            //Act 
            int val1 = 60;
            int val2 = 120;
            swapValues.swapTwoValues(ref val1, ref val2);

            //Assert
            if (val1 != 120)
            {
                throw new Exception("Swapping Not Working");
            }
            else
            {
                Assert.AreEqual(120, val1, "Values Should be Swapped");
            }
        }
    }
}
