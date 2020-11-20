using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects.Library
{
    class GetPageNames
    {
        public static void GetSeleniumEasyPageNames(string listOfElements)
        {
            var pageNames=listOfElements.Split(new string[] { "\r\n"},StringSplitOptions.None);
            foreach (var pageName in pageNames)
            {
                pageName.ToString();
            }
        }
    }
}
