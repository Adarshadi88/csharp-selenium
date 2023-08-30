using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Demo2FbLogin
    {
        public static void Main1(string[] args)
        {
            //ChromeDriver obj = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("your_email_or_phone");
            

            // Find the password input field and enter your password
            IWebElement passwordField = driver.FindElement(By.Id("pass"));
            passwordField.SendKeys("your_password");

            // Find the login button and click it
            IWebElement loginButton = driver.FindElement(By.Name("login"));
            loginButton.Click();

            // You can add some waiting time or logic to handle the post-login flow if needed

            // Close the browser
            driver.Quit();



        }
    }
}