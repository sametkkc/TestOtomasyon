using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SametKikiciTestOtomasyon.Constant;
namespace SametKikiciTestOtomasyon
{
    public class Test 
    {
        static IWebDriver driver;
        BaseRep rep;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            
            driver.Navigate().GoToUrl("https://www.n11.com/");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            

        }
        [Test]
        public void Login()
        {
            rep = new BaseRep(driver);
            rep.ClickElement(LoginD);
            rep.Wait(2);
            rep.SendElement(Email, "deneme@gmail.com");
            rep.Wait(2);
            rep.SendElement(Password, "123456");
            rep.Wait(2);
            rep.ClickElement(loginButton);
            rep.Wait(2);
        }
        [Test]
        public void Search()
        {
            rep = new BaseRep(driver);
            rep.SendElement(searchBar, "Bilgisayar");
            rep.Wait(2);
            rep.ClickElement(searchClick);
            rep.Wait(2);
            rep.ClickElement(choose);
            rep.Wait(2);
            rep.ClickElement(basket);
            rep.Wait(2);
            rep.ClickElement(basketClick);
            rep.Wait(2);
            rep.ClickElement(productAdd);
            rep.Wait(2);
            rep.ClickElement(productDel);
            rep.Wait(3);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
