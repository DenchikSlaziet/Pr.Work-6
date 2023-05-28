using NUnit.Framework;
using OpenQA.Selenium;

namespace Pr.Work_6
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _singInButton = By.XPath("//span[text()='Âîéòè']");
        private readonly By _btnAnotherWay = By.XPath("//span[text()='Äğóãèì ñïîñîáîì']");
        private readonly By _txtLoginInput = By.XPath("//input[@name='username']");
        private const string _login = "kochetkovdenic1@gmail.com";
        private readonly By _btnÑontinue = By.XPath("//span[text()='Ïğîäîëæèòü']");
        private readonly By _txtPasswordInput = By.XPath("//input[@name='password']");
        private readonly By _btnEnterSecond = By.XPath("//button[@data-name='ContinueAuthBtn']");
        private const string _password = "1234@1234";


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
            driver.Navigate().GoToUrl("https://cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var singIn = driver.FindElement(_singInButton);
            singIn.Click();

            var btnAnotherWay = driver.FindElement(_btnAnotherWay);
            btnAnotherWay.Click();

            var txtLoginInput = driver.FindElement(_txtLoginInput);
            txtLoginInput.SendKeys(_login);

            var btnÑontinue = driver.FindElement(_btnÑontinue);
            btnÑontinue.Click();

            var txtPasswordInput = driver.FindElement(_txtPasswordInput);
            txtPasswordInput.SendKeys(_password);

            var btnEnterSecond = driver.FindElement(_btnEnterSecond);
            btnEnterSecond.Click();

            Assert.Pass();
        }
    }
}