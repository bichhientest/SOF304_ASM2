using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SOF304_ASM2._1
{
    public class Tests
    {
        private IWebDriver driver;
        private string url = @"file:///C:/Users/LENOVO/Documents/Zalo%20Received%20Files/contact.html";
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Testcase1()
        {
            IWebElement firstnameElement = driver.FindElement(By.XPath("/html/body/div/form/input[1]"));
            firstnameElement.SendKeys("Bich");
            IWebElement lastnameElement = driver.FindElement(By.Id("lname"));
            lastnameElement.SendKeys("Hien");
            IWebElement countryElement = driver.FindElement(By.XPath("/html/body/div/form/select/option[1]"));
      
            IWebElement subjectElement = driver.FindElement(By.Name("subject"));
            subjectElement.SendKeys("Goodluck!");
            IWebElement submitElement = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            submitElement.Click();


            string expectedUrl = "file:///C:/action_page.php?country=australia&subject=Goodluck%21";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }
        [Test]
        public void Testcase2()
        {
            IWebElement firstnameElement = driver.FindElement(By.XPath("/html/body/div/form/input[1]"));
            //firstnameElement.SendKeys("Bich");
            IWebElement lastnameElement = driver.FindElement(By.Id("lname"));
            lastnameElement.SendKeys("Hien");
            IWebElement countryElement = driver.FindElement(By.XPath("/html/body/div/form/select/option[1]"));

            IWebElement subjectElement = driver.FindElement(By.Name("subject"));
            subjectElement.SendKeys("...");
            IWebElement submitElement = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            submitElement.Click();


            string expectedUrl = "file:///C:/action_page.php?country=australia&subject=Goodluck%21";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }
        [Test]
        public void Testcase3()
        {
            IWebElement firstnameElement = driver.FindElement(By.XPath("/html/body/div/form/input[1]"));
            firstnameElement.SendKeys("Bich");
            IWebElement lastnameElement = driver.FindElement(By.Id("lname"));
         //   lastnameElement.SendKeys("Hien");
            IWebElement countryElement = driver.FindElement(By.XPath("/html/body/div/form/select/option[1]"));

            IWebElement subjectElement = driver.FindElement(By.Name("subject"));
            subjectElement.SendKeys("!");
            IWebElement submitElement = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            submitElement.Click();


            string expectedUrl = "file:///C:/action_page.php?country=australia&subject=Goodluck%21";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }
        [Test]
        public void Testcase4()
        {
            IWebElement firstnameElement = driver.FindElement(By.XPath("/html/body/div/form/input[1]"));
            firstnameElement.SendKeys("Bich");
            IWebElement lastnameElement = driver.FindElement(By.Id("lname"));
              lastnameElement.SendKeys("Hien");
            IWebElement countryElement = driver.FindElement(By.XPath("/html/body/div/form/select/option[1]"));

            IWebElement subjectElement = driver.FindElement(By.Name("subject"));
            //subjectElement.SendKeys("Goodluck!");
            IWebElement submitElement = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            submitElement.Click();


            string expectedUrl = "file:///C:/action_page.php?country=australia&subject=Goodluck%21";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }
        [Test]
        public void Testcase5()
        {
            IWebElement firstnameElement = driver.FindElement(By.XPath("/html/body/div/form/input[1]"));
           // firstnameElement.SendKeys("Bich");
            IWebElement lastnameElement = driver.FindElement(By.Id("lname"));
          //  lastnameElement.SendKeys("Hien");
            IWebElement countryElement = driver.FindElement(By.XPath("/html/body/div/form/select/option[1]"));

            IWebElement subjectElement = driver.FindElement(By.Name("subject"));
            //subjectElement.SendKeys("Goodluck!");

            IWebElement submitElement = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            submitElement.Click();


            string expectedUrl = "file:///C:/action_page.php?country=australia&subject=Goodluck%21";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }

    }
}