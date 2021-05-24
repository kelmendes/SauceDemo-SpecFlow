using SauceDemoSpecFlow.Model;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SauceDemoSpecFlow.Steps
{
    [Binding]
    public class SauceDemoCartSteps
    {
        SauceDemoCartMO CartSteps = new SauceDemoCartMO();

        [Given(@"Devo ser redirecionado para tela inicial do Digital")]
        public void GivenDevoSerRedirecionadoParaTelaInicialDoDigital()
        {
            CartSteps.validarLoginSistema();
        }
        
        [Given(@"Adiciono os itens ""(.*)"" clicando no botão Add to Cart")]
        public void GivenAdicionoOsItensClicandoNoBotaoAddToCart(string listItens)
        {
            CartSteps.adicionarItensAoCarrinho(listItens);

        }
        
        [When(@"O contado de itens no carrinho deve mudar")]
        public void WhenOContadoDeItensNoCarrinhoDeveMudar()
        {
            CartSteps.verificarContadorItensCarrinho(6);
        }
    }
}
