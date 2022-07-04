using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ui.test.Drivers;

namespace ui.test.Pages
{
    class InventoryPage : Browser
    {
        private IWebElement menuBtn => driver.FindElement(By.XPath("//*[@id='react-burger-menu-btn']"));
        private IWebElement menuWindow => driver.FindElement(By.XPath("//*[@id='menu_button_container']/div/div[2]/div[1]"));
        private IWebElement logoutLink => driver.FindElement(By.XPath("//*[@id='logout_sidebar_link']"));
        private IWebElement getValorByProduct(int contador) => driver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[" + contador + "]/div[2]/div[2]/div"));
        

        public IWebElement getValorSite(int valor)
        {
            return getValorByProduct(valor);

        }
        
        public void menuClick() => menuBtn.Click();
        public bool isMenuWindowVisible() => menuWindow.Displayed;
        public bool islogoutExist()
        {
            Thread.Sleep(500);
            return logoutLink.Displayed;
        }

        public void getProduto(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']")).Click();


    }
}
