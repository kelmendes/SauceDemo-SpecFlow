using SauceDemoSpecFlow.Model;
using SauceDemoSpecFlow.utility;
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

        [Given(@"Que o usuário tenha adicionado todos os itens ao carrinho")]
        public void GivenQueOUsuarioTenhaAdicionadoTodosOsItensAoCarrinho()
        {
            CartSteps.adicionarItensAoCarrinho(utils.getStrNomeProduto());
            CartSteps.verificarContadorItensCarrinho(6);
            CartSteps.acessarCartDeCompras();
        }

        [When(@"Validar que todos os estão adicionados")]
        public void WhenValidarQueTodosOsEstaoAdicionados()
        {
            
            CartSteps.verificarItensNoCarrinho(utils.getStrNomeProduto());
        }

        [Given(@"Clico no botão de checkout")]
        public void GivenClicoNoBotaoDeCheckout()
        {
            CartSteps.clicarNoBotãoCheckout();
        }

        [Given(@"Informo os dados básicos para realizar o checkout")]
        public void GivenInformoOsDadosBasicosParaRealizarOCheckout()
        {
            CartSteps.preencherDadosBasicosCheckout();
        }

        [Given(@"Clico em continuar com o checkout")]
        public void GivenClicoEmContinuarComOCheckout()
        {
            CartSteps.continuarCheckout();
        }

        [Given(@"valido a forma de pagamento, entrega e total da compra")]
        public void GivenValidoAFormaDePagamentoEntregaETotalDaCompra()
        {
            Console.WriteLine("Falta implementar!");
        }

        [Given(@"clico em finish")]
        public void GivenClicoEmFinish()
        {
            CartSteps.clicarEmFinish();
        }

        [When(@"Devo ser redirecionado para tela que minha ordem vai ser despachada")]
        public void WhenDevoSerRedirecionadoParaTelaQueMinhaOrdemVaiSerDespachada()
        {
            CartSteps.validarTelaDespacho();
        }


    }
}
