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
    internal class CheckoutSteps : Browser
    {
        InventoryPage inventoryPage = new InventoryPage();
        InventoryItemPage inventoryItemPage = new InventoryItemPage();
        CartPage cartPage = new CartPage();
        CheckOutStepOnePage checkOutStepOnePage = new CheckOutStepOnePage();
        CheckOutStepTwoPage checkOutStepTwoPage = new CheckOutStepTwoPage();
        CheckOutCompletePage CheckOutCompletePage = new CheckOutCompletePage();
        [When(@"adiciono o produto (.+)")]
        public void QuandoAdicionoOProdutoSauceLabsBackpack(string produto)
        {
            inventoryPage.getProduto(produto);
            inventoryItemPage.addToCartClick(produto);

        }

        [When(@"visualizo o carrinho")]
        public void WhenVisualizoOCarrinho()
        {
            cartPage.cartClick();
        }

        [When(@"sigo para as informações do Checkout")]
        public void WhenSigoParaAsInformacoesDoCheckout()
        {
            cartPage.checkOutCartBtnClick();
        }

        [When(@"insiro as seguintes informações pessoais")]
        public void WhenInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            checkOutStepOnePage.yourInformationSendKeys((string)data.FirstName, (string)data.LastName, (string)data.ZipPostalCode);
        }

        [When(@"sigo para o Overview do Checkout")]
        public void WhenSigoParaOOverviewDoCheckout()
        {
           checkOutStepOnePage.checkOutYourInformationClick();
        }

        [When(@"finalizo a compra")]
        public void WhenFinalizoACompra()
        {
            checkOutStepTwoPage.checkOutOverVewClick();
        }

        
        [Then(@"a página de pedido completo é exibida contendo a mensagem (.+)")]
        public void ThenAPaginaDePedidoCompletoEExibidaContendoAMensagem(string texto)
        {
            Assert.That(CheckOutCompletePage.getThankForYourOrder(), Is.EqualTo(texto));
        }




    }
}
