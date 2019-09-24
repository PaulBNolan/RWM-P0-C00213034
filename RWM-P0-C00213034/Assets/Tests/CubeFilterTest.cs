using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CubeFilterTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CubeFilterTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [Test]
        public void collatzTest()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] target = new int[] { 2, 1, 8, 2, 14, 3, 20, 4, 26 };
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            array = CubeFilter.cubes(array);
            

            Assert.AreEqual(array, target);
        }
    }
}
