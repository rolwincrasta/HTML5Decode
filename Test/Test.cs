using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test {
    [TestClass]
    public class Test {
        [TestMethod]
        public void TestSingleCharacters() {
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&colon;"), ":");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&period;"), ".");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&gt;"), ">");
        }

        [TestMethod]
        public void TestSingleRegularCharacter() {
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("A"), "A");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&"), "&");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("a"), "a");
        }

        [TestMethod]
        public void TestMultipleRegularCharacter() {
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("Ab"), "Ab");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("<>;"), "<>;");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("ABC"), "ABC");
        }

        [TestMethod]
        public void TestMultipleCharacters() {
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("Ab&ast;"), "Ab*");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("One &plus;&colon;"), "One +:");
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&;"), "&;"); 
            Assert.AreEqual(HTML5Decode.Utility.HtmlDecode("&#229;"), "å");
        }
    }
}
