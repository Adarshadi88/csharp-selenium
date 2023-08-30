using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Task1
    {
        public static void MainT(string[] args)
        {
            //ChromeDriver obj = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //driver.FindElement(By.LinkText("Create new account")).Click();

            driver.FindElement(By.Name("UserFirstName")).SendKeys("john");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("“john@gmail.com");

            // Select the job title from dropdown
            IWebElement TitleDropdown = driver.FindElement(By.Name("UserTitle"));
            SelectElement JobTitle = new SelectElement(TitleDropdown);
            JobTitle.SelectByValue("IT_Manager_AP");

            IWebElement EmployeesDropdown = driver.FindElement(By.Name("CompanyEmployees"));
            SelectElement EmployeesSelect = new SelectElement(EmployeesDropdown);
            EmployeesSelect.SelectByValue("150");

            IWebElement CountryDropdown = driver.FindElement(By.Name("CompanyCountry"));
            SelectElement CountrySelect = new SelectElement(CountryDropdown);
            CountrySelect.SelectByValue("GB");

            //IWebElement CompanyDropdown = driver.FindElement(By.Name("CompanyName"));
            //SelectElement CompanySelect = new SelectElement(CompanyDropdown);
            //CompanySelect.SelectByValue("GB");
            Thread.Sleep(5000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Name("CompanyName")).Click();
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //CLICK CHECKBOX
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.Name("start my free trial")).Click();
            Console.WriteLine("start");
            //Thread.Sleep(5000);
            //Get displayed error message for phone number
            //IWebElement ErrorMsg = driver.FindElement(By.ClassName("error-msg"));
            //SelectElement Error = new SelectElement(ErrorMsg);
            //ErrorMsg.SelectByValue("GB");

            /*String errmsg = driver.FindElement(By.XPath("//span[@id='UserPhone-H7rU-errMsg']")).GetAttribute("Value");
            if (errmsg.Equals("Enter a valid phone number"))
            {
                Console.WriteLine(errmsg);
            }*/

            String errmsg = driver.FindElement(By.XPath("//span[contains(@id, 'UserPhone' )]")).Text;
            //ClassName("error-msg")).ToString();
            Console.WriteLine(errmsg);
            if (errmsg.Equals("Enter a valid phone number"))
            {
                Console.WriteLine(errmsg);
            }





            Console.ReadLine();





            //driver.Quit();
        }
    }
}
