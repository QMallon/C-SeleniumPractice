using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Tests;



namespace BDD_Practice.Steps
{
    [Binding]
    public class FormFeaturesSteps
    {
        private FormPageElements formPage;
        private string _result;
        IWebDriver driver;
        [Given(@"User is on the form page")]
        public void GivenUserIsOnTheFormPage()
        {
            
                driver.Navigate().GoToUrl("https://localhost:44310/form");
            
            
        }
        
        [When(@"User leaves form blank")]
        public void WhenUserLeavesFormBlank()
        {
           //do nothing
           
                
                formPage.setEmail("");
            
        }
        
        [When(@"clicks Sign in button")]
        public void WhenClicksSignInButton()
        {
            

                           
                driver.FindElement(By.Id("btnSubmit")).Click();
                
            
        }
        
        [When(@"User leaves password blank")]
        public void WhenUserLeavesPasswordBlank()
        {
           

                

                formPage.setEmail("quinn@email.com");
                

            
        }
        
        [When(@"User leaves address blank")]
        public void WhenUserLeavesAddressBlank()
        {




            formPage.setEmail("1");
                formPage.setPassword("1234");
                

            
        }
        
        [When(@"User leaves city blank")]
        public void WhenUserLeavesCityBlank()
        {
            

                

                
                formPage.setAddress("1234 Street");
               

            
        }
        
        [When(@"User leaves zip blank")]
        public void WhenUserLeavesZipBlank()
        {
            
                
                

                
                formPage.setCity("City");
                
                
            
        }
        
        [When(@"User inputs all information")]
        public void WhenUserInputsAllInformation()
        {
            formPage.setEmail("1");
            formPage.setPassword("1");
            formPage.setAddress("1");
            formPage.setCity("city");
            formPage.setZip("1");
                formPage.setcheckBox();


            
           
        }
        
       
        
        [Then(@"Alert will read ""(.*)""")]
        public void ThenAlertWillRead(string p0)
        {
            

                IAlert alert = driver.SwitchTo().Alert();
                _result = alert.Text;
                _result.Should().Be(p0);
            alert.Accept();
            
        }
        [BeforeScenario]
        public void setupScenarioEnv()
        {
            driver = new ChromeDriver();
            formPage = new FormPageElements(driver);
        }
        [AfterScenario]
        public void tearDownEnv()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }
    }
}
