using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    class PriceVerificationStep : Browser
    {
        InventoryPage inventoryPage = new InventoryPage();
        
        [Then(@"verifico se o valor (.+) corresponde ao item de número (.+)")]
        public void ThenVerificoOPrecoDosSeguintesItens(string valor, string contador)
        {
            
            Assert.That(inventoryPage.getValorSite(int.Parse(contador)).Text, Is.EqualTo(valor));
            
                
        }


    }
}
