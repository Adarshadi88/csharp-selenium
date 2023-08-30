using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Unisys.SeleniumConcepts
{
    public class Program
    {
        public static void Main2(string[] args)
        {
            //ChromeDriver obj = new ChromeDriver();
            IWebDriver obj = new ChromeDriver();
            obj.Url= "https://www.facebook.com";
            string actualTitle = obj.Title;
            Console.WriteLine(actualTitle);
            string pageSource = obj.PageSource;
            Console.WriteLine(pageSource);
            obj.Quit();



        }
    }
}