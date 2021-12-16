namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System;

    public static class Actions
    {
        public static IWebDriver InitializeDriver()

        {
            IWebDriver Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return Driver;
        }

        public static void FillLoginForm(string email, string password, IWebDriver driver)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost(driver);

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(email);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.LoginButton.Click();
        }
    }
}
