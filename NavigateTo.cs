namespace AutoFramework
{
    using AutoFramework.Pages;
    using OpenQA.Selenium;
    using System.Threading;

    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughLoginButton(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            LoginButton loginbutton = new LoginButton(driver);
            UsernameCasePost ucPost = new UsernameCasePost(driver);

            menu.LoginButton.Click();
            
            loginbutton.UsernameCase.Click();
            
            ucPost.LoginFormLink.Click();
            Thread.Sleep(500);

        }

        public static void LoginFormScenarioThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            LoginButton loginbutton = new LoginButton(driver);

            menu.LoginButton.Click();
            
            
            Thread.Sleep(2500);

        }
    }
}
