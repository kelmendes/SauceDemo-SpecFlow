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
            driver = Hook.getDrivers();
        }

        public bool validarCarregamentoSistemaAposLogin()
        {
            bool temp = false;
            try
            {
                temp = driver.FindElement(By.XPath(divContainerListaDeItensHome)).Displayed;
                return temp;
            }
            catch (Exception erro) { }
            return temp;
        }

        public IWebElement adicionarItemCarrinho(String intenAdicionar)
        {
            return driver.FindElement(By.XPath("//div[text()='" + intenAdicionar + "']/../../../div[2]/button"));
        }

        public bool listaDeItensHome()
        {
            return driver.FindElement(By.XPath(divContainerListaDeItensHome)).Displayed;
        }

        public IWebElement cartIcones()
        {
            return driver.FindElement(By.XPath(cartIcone));
        }

        public IWebElement quantidadeItensCarrinho()
        {
            return driver.FindElement(By.XPath(spanQtdItensCarrinho));
        }

        public IWebElement botãoCheckout()
        {
            return driver.FindElement(By.XPath(btnCheckout));
        }

        public IWebElement setInputCheckoutName( )
        {
            return driver.FindElement(By.XPath(inputCheckoutName));
        }

        public IWebElement setInputCheckoutLastName()
        {
            return driver.FindElement(By.XPath(inputCheckoutLastName));
        }

        public IWebElement setInputCheckoutCEP()
        {
            return driver.FindElement(By.XPath(inputCheckoutCEP));
        }

        public IWebElement botãoCheckoutContinue()
        {
            return driver.FindElement(By.XPath(btnCheckoutContinue));
        }

        public IWebElement botãoFinish()
        {
            return driver.FindElement(By.XPath(btnFinish));
        }

        public bool verificarItenNoCarrinho(String strNomeItem)
        {
            return driver.FindElement(By.XPath("//div[text()='" + strNomeItem + "']")).Displayed;
        }

        public bool validarTelaDespachoOrdem()
        {
            //h2[@class='complete-header'] = THANK YOU FOR YOUR ORDER
            //div[@class='complete-text'] = Your order has been dispatched, and will arrive just as fast as the pony can get there!
            bool val1 = driver.FindElement(By.XPath("//h2[@class='complete-header']")).Displayed;
            bool val2 = driver.FindElement(By.XPath("//div[@class='complete-text']")).Displayed;
            return (val1 && val2);
        }
    }
}
