// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver drive = new ChromeDriver();
drive.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

IWebElement userNameElement = drive.FindElement(By.Id("Username"));
userNameElement.SendKeys("hari");

IWebElement passwordElement = drive.FindElement(By.Id("password"));
passwordElement.SendKeys("123123");

IWebElement loginButtonElement = drive.FindElement(By.Id("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButtonElement.Click();

