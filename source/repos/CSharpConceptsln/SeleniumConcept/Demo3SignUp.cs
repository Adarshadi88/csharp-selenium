using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Demo3SignUp
    {
        public static void Main3(string[] args)
        {
            //ChromeDriver obj = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.facebook.com";
            driver.FindElement(By.LinkText("Create new account")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("john");
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            // Select the birthdate
            IWebElement birthDayDropdown = driver.FindElement(By.Name("birthday_day"));
            SelectElement birthDaySelect = new SelectElement(birthDayDropdown);
            birthDaySelect.SelectByValue("20");

            IWebElement birthMonthDropdown = driver.FindElement(By.Name("birthday_month"));
            SelectElement birthMonthSelect = new SelectElement(birthMonthDropdown);
            birthMonthSelect.SelectByValue("12");

            IWebElement birthYearDropdown = driver.FindElement(By.Name("birthday_year"));
            SelectElement birthYearSelect = new SelectElement(birthYearDropdown);
            birthYearSelect.SelectByValue("2000");



            //click on custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();
         
            //click on signup
            driver.FindElement(By.Name("websubmit")).Click();





            //driver.Quit();
        }
        }
}
