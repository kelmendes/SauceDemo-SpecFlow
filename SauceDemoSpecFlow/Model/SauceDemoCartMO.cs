using NUnit.Framework;
using SauceDemoSpecFlow.Pageobject;
using SauceDemoSpecFlow.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoSpecFlow.Model
{
    class SauceDemoCartMO
    {
        SauceDemoCartPO CartPO = new SauceDemoCartPO();

        public void validarLoginSistema()
        {
            Assert.IsTrue(CartPO.validarCarregamentoSistemaAposLogin(), "[ASSERT] - Sistema não carregou a tela inicial após login!");
        }

        public void adicionarItensAoCarrinho(string ItensAdicionar)
        {
            string[] listItensAdicionar = ItensAdicionar.Split(',');
            foreach (var iten in listItensAdicionar) {
                CartPO.adicionarItemCarrinho(iten.Trim()).Click();
            }
        }

        public void verificarContadorItensCarrinho(int intQuantidadeItens)
        {
            Assert.AreEqual(intQuantidadeItens.ToString(), CartPO.quantidadeItensCarrinho().Text);   
                ///CartPO.quantidadeItensCarrinho();
        }

        public void verificarItensNoCarrinho(string itensCarrinho)
        {
            string[] listaItensCarrinho = itensCarrinho.Split(',');
            foreach (var iten in listaItensCarrinho)
            {
                Assert.True(CartPO.verificarItenNoCarrinho(iten.Trim()), "[ASSERT] - " + iten.Trim() + " não está no carrinho!");
            }
        }

        public void acessarCartDeCompras()
        {
            CartPO.cartIcones().Click();
        }

        public void clicarNoBotãoCheckout()
        {
            utils.scrollToElement(CartPO.botãoCheckout());
            CartPO.botãoCheckout().Click();
        }

        public void preencherDadosBasicosCheckout()
        {
            CartPO.setInputCheckoutName().SendKeys("Teste");
            CartPO.setInputCheckoutLastName().SendKeys("Nome");
            CartPO.setInputCheckoutCEP().SendKeys("55034290");

        }

        public void continuarCheckout()
        {
            utils.scrollToElement(CartPO.botãoCheckoutContinue());
            CartPO.botãoCheckoutContinue().Click();
        }

        public void clicarEmFinish()
        {
            utils.scrollToElement(CartPO.botãoFinish());
            CartPO.botãoFinish().Click();
        }

        public void validarTelaDespacho()
        {
            Assert.True(CartPO.validarTelaDespachoOrdem(), "[ASSERT] - não foi redirecionado para tela de Despacho!");
        }
    }
}
