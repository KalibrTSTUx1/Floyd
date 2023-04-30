using Microsoft.VisualStudio.TestTools.UnitTesting;
using Floyd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Floyd.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void FloydTest()
        {
            string[] x1 = { "He   was lying  face down on the   ground again.   The  smell of   the ",
                             "Forest filled his  nostrils. He could feel  the cold hard ground  ",
                             "beneath his cheek, and the hinge of his glasses, which had been ",
                             "knocked sideways by the fall, cutting into his temple.",
                "   ",
                             "                    end!!!"};
            string[] expct = { 
                "He was lying face down on the ",
                "ground again. The smell of the ",
                "Forest filled his nostrils. He ",
                "could feel the cold hard ",
                "ground beneath his cheek, and ",
                "the hinge of his glasses, ",
                "which had been knocked ",
                "sideways by the fall, cutting ",
                "into his temple. "
            };
            string[] res = Class1.Floyd(x1);
            for (int i = 0; i < res.Length; i++)
                Assert.AreEqual(res[i], expct[i]);

        }
        [TestMethod()]
        public void ConvertToCorrectStrArrTest()
        {
            string[] x6 = { "12345678901234567890 12345678901", "123", "456", "789", "123456789012345" };
            string[] res = Class1.ConvertToCorrectStrArr(x6);
            string[] expct = { "12345678901234567890 ", "12345678901 123 456 789 ", "123456789012345 " };
            for (int i = 0; i < res.Length; i++)
                Assert.AreEqual(res[i], expct[i]);
        }

        [TestMethod()]
        public void FillArrWOSpacesTest()
        {
            string[] x5 = { "as     jdjj assn", "jdakj skjdaj", " ", " jdjd    jdj" };
            string[] res = Class1.FillArrWOSpaces(x5);
            string[] expct = { "as     jdjj assn", "jdakj skjdaj" };
            for (int i = 0; i < res.Length; i++)
                Assert.AreEqual(res[i], expct[i]);
        }

        [TestMethod()]
        public void IsSpaceStrTest()
        {
            string x2 = "     ";
            if (!Class1.IsSpaceStr(x2))
                Assert.Fail();
        }

        [TestMethod()]
        public void FormatStrArrTest()
        {
            string[] x4 = { "as     jdjj assn", "jdakj skjdaj", " jdjd    jdj" };
            string[] res = Class1.FormatStrArr(x4);
            string[] expct = { "as jdjj assn", "jdakj skjdaj", "jdjd jdj" };
            for (int i = 0; i < res.Length; i++)
                Assert.AreEqual(res[i], expct[i]);
        }
    }
}