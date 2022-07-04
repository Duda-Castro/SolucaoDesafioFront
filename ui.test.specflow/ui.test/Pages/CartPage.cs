using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    class CartPage : Browser
    {
        private IWebElement cartLink => driver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a"));
        private IWebElement checkOutCartBtn => driver.FindElement(By.XPath("//*[@id='checkout']"));


        public void cartClick() => cartLink.Click();
        public void checkOutCartBtnClick() => checkOutCartBtn.Click();
    }
}
