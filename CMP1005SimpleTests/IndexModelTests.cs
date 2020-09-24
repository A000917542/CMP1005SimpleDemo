using CMP1005SimpleDemo.Pages;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace CMP1005SimpleTests
{
    [TestClass]
    public class IndexModelTests
    {
        [TestMethod]
        public void GetDate_Returns_String()
        {
            var loggerFactory = (ILoggerFactory)new LoggerFactory();
            var logger = loggerFactory.CreateLogger<IndexModel>();

            CMP1005SimpleDemo.Pages.IndexModel model = new CMP1005SimpleDemo.Pages.IndexModel(logger);

            //string expected = "Hello World";

            var result = model.GetDate();

            //var x = typeof(string);

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void GetDate_Returns_HelloWorld()
        {
            var loggerFactory = (ILoggerFactory)new LoggerFactory();
            var logger = loggerFactory.CreateLogger<IndexModel>();

            CMP1005SimpleDemo.Pages.IndexModel model = new CMP1005SimpleDemo.Pages.IndexModel(logger);

            string expected = "Hello World";

            var result = model.GetDate();

            //var x = typeof(string);

            Assert.AreEqual(expected, result);
        }
    }
}
