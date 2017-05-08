using System;
using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace Multi_TranslatorTest
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void Translate()
        {
            string text = "Hello";
            string expected = "Bonjour";
            string actual = "";
            string source = "EN";
            string target = "FR";
            string url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyDF_M6DlvJXlLchm0YF8iHQoxTN-IRSgT8";
            url += "&source=" + source;
            url += "&target=" + target;
            url += "&q=" + Server.UrlEncode(text.Text.trim());

        }
    }
}
