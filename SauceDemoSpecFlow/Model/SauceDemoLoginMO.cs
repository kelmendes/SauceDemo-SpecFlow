using SauceDemoSpecFlow.PageObjects;
using SauceDemoSpecFlow.Stepdefinition.Hook;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoSpecFlow.Models
{
    class SauceDemoLoginMO
    {
        SauceDemoLoginPO LoginPO = new SauceDemoLoginPO();
        internal void realizarLogin(string strNomeUsuario, string strSenhaUsuario)
        {
            LoginPO.InputUserName().SendKeys(strNomeUsuario);
            LoginPO.InputPassword().SendKeys(strSenhaUsuario);
        }

        internal void clicarBotãoLogin()
        {
            LoginPO.botãoLogin().Click();
        }

        internal void fazerlogout()
        {
            LoginPO.botãoMenuLateral().Click();
            LoginPO.botãoLogoutMenuLateral().Click();
        }
    }
}
