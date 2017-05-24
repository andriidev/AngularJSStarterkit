using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTest.Utilities
{
    class Helper
    {


        public static List<string> ConvertWebElementList(IList<IWebElement> elementList)
        {
            List<string> list = new List<string>();

            foreach (IWebElement element in elementList)    
            {
                list.Add(element.Text);
            }

            return list;
        }
    }
}
