using NUnit.Framework;
using TechTalk.SpecFlow;
using ui.test.Drivers;
using ui.test.Pages;
using TechTalk.SpecFlow.Assist;

namespace ui.test.Steps
{
    [Binding]
    class LoginSteps : Browser
    {

        private LoginPage loginPage = new LoginPage();
        private InventoryPage inventoryPage = new InventoryPage();


        [Given(@"que acesso o site")]
        public void DadoQueAcessoOSite()
        {
            Browser.loadPage("https://www.saucedemo.com/");
        }

        [Then(@"vejo que estou na login page")]
        public void EntaoVejoQueEstouNaLoginPage()
        {
            Assert.That(loginPage.isBotImgExist(), Is.True);
        }

        [When(@"informo as seguintes credenciais")]
        public void QuandoInformoAsSeguintesCredenciais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.loginSendKeys((string)data.Username, (string)data.Password);
        }

        [When(@"me autentico no sistema")]
        public void QuandoMeAutenticoNoSistema()
        {
            loginPage.loginClick();

        }

        [Then(@"o menu do usuário está visivel")]
        public void ThenOMenuDoUsuarioEstaVisivel()
        {
            inventoryPage.menuClick();
            Assert.That(inventoryPage.isMenuWindowVisible, Is.EqualTo(true));
        }



        [Then(@"o usuário aparece logado")]
        public void ThenOUsuarioApareceLogado()
        {
           Assert.That(inventoryPage.islogoutExist(), Is.EqualTo(true));
        }


        [Then(@"um erro aparece informando que o usuário está bloqueado")]
        public void EntaoUmErroApareceInformandoQueOUsuarioEstaBloqueado()
        {
            Assert.That(loginPage.getErrorMsg(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));


        }

    }
}
