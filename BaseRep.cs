using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SametKikiciTestOtomasyon
{
    public class BaseRep
    {
        IWebDriver driver;

        public BaseRep(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(By entity)
        {
            return driver.FindElement(entity);
        }

        public void ClickElement(By entity)
        {
            FindElement(entity).Click();
        }

        public void SendElement(By entity, string text)
        {
            FindElement(entity).SendKeys(text);
        }

        public void Wait(int second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }

    }
}
