using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Steps
{
    class Class1
    {
        public void Ololo() {
            int pageCount;
            S120decisionPaymentsPage.SetDriver(driver);

            if (S120decisionPaymentsPage.GetPendingPaginationCount() > 0)
            {
                pageCount = S120decisionPaymentsPage.GetPendingPaginationCount();
            }
            else
            {
                pageCount = 1;
            }

            for (var page = 1; page <= pageCount; page++)
            {
                if (page != 1)
                {
                    S120decisionPaymentsPage.ClickPendingPaginationNumber(page);
                }
            }
            driver.DoubleClickOnElement(S120decisionPaymentsPage.SeventhElementOfRowOfThePandingTable);
        }

            [Then(@"I see that payment is not created")]
        public void ThenISeeThatPaymentIsNotCreated()
       
    
    }
}
