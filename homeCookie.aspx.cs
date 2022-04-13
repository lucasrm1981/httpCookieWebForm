using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace httpCookieWebForm
{
    public partial class homeCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GravandoDadosCookie(string nomeCookie)
        {
            // Verificando se já existe o cookie na máquina do usuário
            HttpCookie cookie = Request.Cookies[nomeCookie];
            if (cookie == null)
            {
                // Criando a Instância do cookie
                cookie = new HttpCookie(nomeCookie);
                //Adicionando a propriedade "Nome" no cookie
                cookie.Values.Add("valorNome", " James Bond");
                //Adicionando a propriedade "Naturalidade" no cookie
                cookie.Values.Add("valorNaturalidade", " MI6 Inglaterra");
                //Adicionando a propriedade "Idade" no cookie
                cookie.Values.Add("valorIdade", " 40 anos");
                //Adicionando a propriedade "Profissão" no cookie
                cookie.Values.Add("valorProfissao", " Programador C# ASP .NET");
                //colocando o cookie para expirar em 365 dias
                cookie.Expires = DateTime.Now.AddDays(365);
                // Definindo a segurança do nosso cookie
                cookie.HttpOnly = true;
                // Registrando cookie
                this.Page.Response.AppendCookie(cookie);

            }
        }

        /*
         * Método 02
         *  Método responsável por obter as propriedades de um cookie caso ele exista
         */

        public void getPropriedadesCookie(string nomeCookie)
        {
            // Obtém a requisição com dos dados do cookie
            HttpCookie cookie = ObterRequisicaoCookie(nomeCookie);
            if (cookie != null)
            {
                // Separa os valores das propriedade
                string[] valores = cookie.Value.ToString().Split('&');
                // Varre os valores das propriedades encontrados
                for (int i = 0; i < valores.Length; i++)
                {
                    // Escreve os valores das propriedades encontradas
                    ltrCookie.Text += "Cookie - Propriedade: " + (i + 1) + " - " + valores[i] + "<br/>";
                }
            }
            else ltrCookie.Text = string.Empty;
        }

        /*
         * Método 03
         * Método responsável por Obter a requisição HttpCookie de um determinado cookie caso ele exista
         */
        private HttpCookie ObterRequisicaoCookie(string nomeCookie)
        {
            try
            {
                // Retornando o cookie caso exista
                return this.Page.Request.Cookies[nomeCookie];
            }
            catch
            {
                // Caso não exista o cookie informado, retorna NULL
                return null;
            }
        }

        /*
        * Método 04
        * Método responsável por remover um determinado cookie
        */
        private void removerCookie(string nomeCookie)
        {
            // Removendo o Cookie
            Response.Cookies[nomeCookie].Expires = DateTime.Now.AddDays(-1);
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {
            GravandoDadosCookie("JAMES_BOND");
        }

        protected void btnLer_Click(object sender, EventArgs e)
        {
            getPropriedadesCookie("JAMES_BOND");
        }

        protected void btnRemoverCookie_Click(object sender, EventArgs e)
        {
            removerCookie("JAMES_BOND");
            ltrCookie.Text = string.Empty;
        }
    }
}