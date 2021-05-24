using OpenQA.Selenium;
using SauceDemoSpecFlow.Models;
using SauceDemoSpecFlow.Stepdefinition.Hook;
using System;
using TechTalk.SpecFlow;

namespace SauceDemoSpecFlow.Steps
{
    [Binding]
    public class SauceDemoLoginSteps
    {
        private IWebDriver driver;
        SauceDemoLoginMO LoginSteps = new SauceDemoLoginMO();

        [Given(@"Dado que consigo   carregar a aplicação")]
        public void GivenDadoQueConsigoCarregarAAplicacao()
        {
            Hook.SetUp();
            driver = Hook.getDrivers();
        }
        
        [Given(@"Informo o nome de ""(.*)"" e ""(.*)"" válidos")]
        public void GivenInformoONomeDeEValidos(string strNomeUsuario, string strSenhaUsuario)
        {
            LoginSteps.realizarLogin(strNomeUsuario, strSenhaUsuario);
        }
        
        [When(@"Clico no botão login")]
        public void WhenClicoNoBotaoLogin()
        {
            LoginSteps.clicarBotãoLogin();
        }
        
        [Then(@"Devo ser redirecionado para tela inicial do Digital")]
        public void ThenDevoSerRedirecionadoParaTelaInicialDoDigital()
        {
            Console.Write("Falta implemtnar");
        }
        
        [Then(@"Então deve fazer logout")]
        public void ThenEntaoDeveFazerLogout()
        {
            LoginSteps.fazerlogout();
            Hook.tearDown();
        }

        [Then(@"Devo ser exibido um alerta que o esse usuario está bloqueado")]
        public void ThenDevoSerExibidoUmAlertaQueOEsseUsuarioEstaBloqueado()
        {
            LoginSteps.alertaUsuarioBloqueadoOuUsuarioErrado();
            Hook.tearDown();
        }

        [Then(@"Devo ser exibido um alerta que o esse usuario ou senha está errado")]
        public void ThenDevoSerExibidoUmAlertaQueOEsseUsuarioOuSenhaEstaErrado()
        {
            LoginSteps.alertaUsuarioBloqueadoOuUsuarioErrado();
            Hook.tearDown();
        }

    }
}
