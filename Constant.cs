using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SametKikiciTestOtomasyon
{
    public class Constant
    {
        public static By LoginD = By.ClassName("btnSignIn");

        public static By Email = By.Id("email");

        public static By Password = By.Id("password");

        public static By loginButton = By.Id("loginButton");

        public static By searchBar = By.Id("searchData");

        public static By searchClick = By.ClassName("searchBtn");
        
        public static By choose = By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/section[1]/div[2]/ul/li[1]/div/div[1]/a/img");
        
        public static By basket = By.XPath("/html/body/div[1]/div[2]/div/div[3]/div[1]/div[1]/div[2]/div[4]/div[2]/div[2]/a");
        
        public static By basketClick = By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[4]/a/i");

        public static By productAdd = By.XPath("//*[@id='newCheckout']/div/div[1]/div[2]/div[1]/section/table[2]/tbody/tr/td[3]/div[1]/div/span[1]");

        public static By productDel = By.XPath("//*[@id='newCheckout']/div/div[1]/div[2]/div[1]/section/table[2]/tbody/tr/td[1]/div[3]/div[2]/span[1]");
    }
}
