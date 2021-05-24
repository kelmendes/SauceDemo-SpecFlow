using OpenQA.Selenium;
using SauceDemoSpecFlow.Stepdefinition.Hook;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoSpecFlow.Pageobject
{
    class SauceDemoCartPO
    {
        private IWebDriver driver;
        public String divContainerListaDeItensHome = "//*[@id='inventory_container']";

        public String spanQtdItensCarrinho = "//span[@class='shopping_cart_badge']";
        public String cartIcone = "//a[@class='shopping_cart_link']";

        public String btnCheckout = "//*[@id='checkout']";
        public String inputCheckoutName = "//*[@id='first-name']";
        public String inputCheckoutLastName = "//*[@id='last-name']";
        public String inputCheckoutCEP = "//*[@id='postal-code']";
        public String btnCheckoutContinue = "//*[@id='continue']";
        public String btnFinish = "//*[@id='finish']";

        public SauceDemoCartPO()
        {
            // driver = Hook.getDrivers();
        }

        public bool validarCarregamentoSistemaAposLogin()
        {
            bool temp = false;
            try
            {
                temp = Hook.getDrivers().FindElement(By.XPath(divContainerListaDeItensHome)).Displayed;
                return temp;
            }
            catch (Exception erro) { }
            return temp;
        }

        public IWebElement adicionarItemCarrinho(String intenAdicionar)
        {
            return Hook.getDrivers().FindElement(By.XPath("//div[text()='" + intenAdicionar + "']/../../../div[2]/button"));
        }

        public bool listaDeItensHome()
        {
            return Hook.getDrivers().FindElement(By.XPath(divContainerListaDeItensHome)).Displayed;
        }

        public IWebElement cartIcones()
        {
            return Hook.getDrivers().FindElement(By.XPath(cartIcone));
        }

        public IWebElement quantidadeItensCarrinho()
        {
            return Hook.getDrivers().FindElement(By.XPath(spanQtdItensCarrinho));
            //return Integer.parseInt(strQuantideCart);
        }

        public IWebElement botãoCheckout()
        {
            //scrollToElement(By.XPath(btnCheckout));
            return Hook.getDrivers().FindElement(By.XPath(btnCheckout));
        }

        public IWebElement setInputCheckoutName( )
        {
            return Hook.getDrivers().FindElement(By.XPath(inputCheckoutName));
        }

        public IWebElement setInputCheckoutLastName()
        {
            return Hook.getDrivers().FindElement(By.XPath(inputCheckoutLastName));
        }

        public IWebElement setInputCheckoutCEP(String strInputCheckoutCEP)
        {
            return Hook.getDrivers().FindElement(By.XPath(inputCheckoutCEP));
        }

        public IWebElement botãoCheckoutContinue()
        {
            //scrollToElement(By.XPath(btnCheckoutContinue));
            return Hook.getDrivers().FindElement(By.XPath(btnCheckoutContinue));
        }

        public IWebElement botãoFinish()
        {
            //scrollToElement(By.XPath(btnFinish));
            return Hook.getDrivers().FindElement(By.XPath(btnFinish));
        }

        public bool verificarItenNoCarrinho(String strNomeItem)
        {
            return Hook.getDrivers().FindElement(By.XPath("//div[text()='" + strNomeItem + "']")).Displayed;
        }
    }
}
