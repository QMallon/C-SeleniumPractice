using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Text;





namespace Tests
{
    class FormPageElements
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = ("inputEmail4"))]
        private IWebElement emailBox;

        [FindsBy(How = How.Id, Using = ("inputPassword4"))]
        private IWebElement passwordBox;

        [FindsBy(How = How.Id, Using = ("inputAddress"))]
        private IWebElement addressBox1;

        [FindsBy(How = How.Id, Using = ("inputCity"))]
        private IWebElement cityBox;

        [FindsBy(How = How.Id, Using = ("inputZip"))]
        private IWebElement zipBox;

        [FindsBy(How = How.Id, Using = ("gridCheck"))]
        private IWebElement checkBox;


        public FormPageElements(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);

        }

        public void setEmail(String value)
        {
            this.emailBox.SendKeys(value);
        }

        public void setPassword(String value)
        {
            this.passwordBox.SendKeys(value);
        }

        public void setAddress(String value)
        {
            this.addressBox1.SendKeys(value);
        }

        public void setCity(String value){
            this.cityBox.SendKeys(value);
        }

        public void setZip(String value)
        {
            this.zipBox.SendKeys(value);
        }
        public void setcheckBox()
        {
            checkBox.Click();
        }

    }
}
