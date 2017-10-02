using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ATQC3
{
    [TestClass]
    public class Class1
    {//Main
        [TestMethod]
        public void Main()
        {
            IWebDriver webDriver = new ChromeDriver();

            webDriver.Url = "https://ru.wikipedia.org/";

            webDriver.FindElement(By.LinkText("Религия")).Click();

            webDriver.FindElement(By.LinkText("Буддизм")).Click();

            webDriver.FindElement(By.Id("p - logo")).Click();

            Assert.IsTrue(webDriver.FindElement(By.LinkText("Добро пожаловать в Википедию")).Displayed);

     
            webDriver.Close();
            
        }
    }
}
