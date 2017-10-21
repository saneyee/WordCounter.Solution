using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void WordCounter_RepeatCountsForStringofWords_int()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("No lemon no melon","No");
            var output = 2;
            int result = newRepeatCounter.CountRepeats();
            Assert.AreEqual(output, result);
        }
        [TestMethod]
        public void WordCounter_RepeatCountsForStringofInts_int()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("123 34566 78 78 456 78","78");
            var output = 3;
            int result = newRepeatCounter.CountRepeats();
            Assert.AreEqual(output, result);
        }
        [TestMethod]
        public void WordCounter_FullWordMatch_int()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter("I am going to Paris at 7am.","am");
            var output = 1;
            int result = newRepeatCounter.CountRepeats();
            Assert.AreEqual(output, result);
        }
 }






}
