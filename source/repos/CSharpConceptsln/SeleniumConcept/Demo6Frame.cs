using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    class Demo6Frame
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);



            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");
            driver.FindElement(By.XPath("//a[text()='CONTINUE']")).Click();







            //enter userid as john123
        }

    }
}
