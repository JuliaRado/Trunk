using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATQC3
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void Main()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://ru.wikipedia.org/";

            webDriver.FindElement(By.LinkText("География")).Click();

           

            webDriver.Close();

        }
    }
}
