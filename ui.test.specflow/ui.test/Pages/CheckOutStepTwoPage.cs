using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    class CheckOutStepTwoPage : Browser
    {
        private IWebElement checkOutOverViewBtn => driver.FindElement(By.XPath("//*[@id='finish']"));

        public void checkOutOverVewClick() => checkOutOverViewBtn.Click();

    }
}
