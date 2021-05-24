using NUnit.Framework;
using SauceDemoSpecFlow.Pageobject;
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
            Console.Write(listItensAdicionar);
            foreach (var iten in listItensAdicionar) {
                Console.Write(iten);
                CartPO.adicionarItemCarrinho(iten.Trim()).Click();
            }
        }

        public void verificarContadorItensCarrinho(int intQuantidadeItens)
        {
            Assert.AreEqual(intQuantidadeItens.ToString(), CartPO.quantidadeItensCarrinho().Text);   
                ///CartPO.quantidadeItensCarrinho();
        }

        
    }
}
