using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace Tests
{
    public class TestWebAppTests
    {

        private FormPageElements formPage;
        
        public static void tearDown(IWebDriver driver)
        {
            driver.Close();
            driver = null;
        }
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadAboutPage()
        { 
            using(IWebDriver driver = new ChromeDriver())
            {
                formPage = new FormPageElements(driver);
                driver.Navigate().GoToUrl("https://localhost:44310/");
                String title = driver.Title;
                Assert.Equal("Home page - TestWebApp", title);
                
            }
            
        }

        [Fact]
        public void LoadFormPage()
        
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                //driver.FindElement(By.XPath("/ html / body / nav / div / div[2] / ul / li[4] / a")).Click();
                String title = driver.Title;
                Assert.Equal("FormTest - TestWebApp", title);

            }
        }
        [Fact]
        public void submitFormBlank()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("Email is blank", alert.Text);

            }
        }
        [Fact]
        public void submitFormBlankPassword()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                formPage = new FormPageElements(driver);
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage.setEmail("quinn@email.com");
                
                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("password is blank", alert.Text);

            }
        }

        [Fact]
        public void submitFormBlankAddress()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage = new FormPageElements(driver);
               
                formPage.setEmail("quinn@email.com");
                formPage.setPassword("1234");
                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("address is blank", alert.Text);

            }
        }

        [Fact]
        public void submitFormBlankCity()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage = new FormPageElements(driver);

                formPage.setEmail("quinn@email.com");
                formPage.setPassword("1234");
                formPage.setAddress("1234 Street");
                
                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("city is blank", alert.Text);
            }
        }

        [Fact]
        public void submitFormBlankZip()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage = new FormPageElements(driver);

                formPage.setEmail("quinn@email.com");
                formPage.setPassword("1234");
                formPage.setAddress("1234 Street");
                formPage.setCity("City");
                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("zip is blank", alert.Text);
            }
        }

        [Fact]
        public void submitFormBlankCheck()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage = new FormPageElements(driver);

                formPage.setEmail("quinn@email.com");
                formPage.setPassword("1234");
                formPage.setAddress("1234 Street");
                formPage.setCity("City");
                formPage.setZip("12345");

                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("checkbox is blank", alert.Text);
            }
        }

        [Fact]
        public void SubmitFormSuccess()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://localhost:44310/form");
                formPage = new FormPageElements(driver);

                formPage.setEmail("quinn@email.com");
                formPage.setPassword("1234");
                formPage.setAddress("1234 Street");
                formPage.setCity("City");
                formPage.setZip("12345");
                formPage.setcheckBox();

                driver.FindElement(By.Id("btnSubmit")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.Equal("Submited Form", alert.Text);
            }
        }

    }
}
