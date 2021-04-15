
using AutoPractice9;
using NUnit.Framework;
using System;
using System.IO;

namespace AutoPractice9Tests
{
    [TestFixture]
    class PageTest
    {
        [Test]
        public void TestPageTitle()
        {
            string title = "Homepage title";
            var page = new Page(title);
            Assert.AreEqual(title, page.Title);
        }

        [Test]
        public void TestPageWidth()
        {
            var page = new Page("title");
            double val = 700;
            Assert.AreNotEqual(val, page.width);
        }

        [Test]
        public void TestPageElements()
        {
            var page = new Page("title");
            int[] val = (int[])page.elements.Clone();
            Assert.AreNotSame(val, page.elements);
        }

        [Test]
        public void TestPageElements2()
        {
            var page = new Page("title");
            int val = 1;
            Assert.Contains(val, page.elements);
        }

        [Test]
        public void TestPageInitiated()
        {
            var page = new Page("title");
            //IsTrue, IsFalse, IsEmpty, IsNull, IsNotNull, IsNotEmpty
            Assert.IsNull(page.IsInitiated);
        }

        [Test]
        public void TestPageField()
        {
            var page = new Page("title");
            //IsTrue, IsFalse, IsEmpty, IsNull, IsNotNull, IsNotEmpty
            Assert.IsNotNull(page.Field);
            Assert.IsInstanceOf(typeof(Page.FieldClass), page.Field);
            string var = "f";
            Assert.IsTrue("title".Contains(var), $"Title doens't contains element {var}");
        }

        [Test]
        public void TestPageDescription()
        {
            var page = new Page("title");
            //IsTrue, IsFalse, IsEmpty, IsNull, IsNotNull, IsNotEmpty
            Assert.IsNotEmpty(page.Description);
            StringAssert.Contains(" is ", page.Description);
        }

        [Test]
        public void TestPageEmail()
        {
            var page = new Page("title");
            StringAssert.AreEqualIgnoringCase("SOME@email2", page.Email);
        }

        [Test]
        public void TestFileExists()
        {
            FileInfo file = new FileInfo("111.txt");
            FileAssert.Exists(file);
            DirectoryAssert.DoesNotExist("11");
        }
    }
}
