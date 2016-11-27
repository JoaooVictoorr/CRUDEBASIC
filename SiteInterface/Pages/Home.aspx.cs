using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteInterface
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAcessar(object sender, EventArgs e)
        {
            string opcao = ddMenu.SelectedValue;

            switch (opcao)
            {
                case "1":
                Response.Redirect("Cadastro.aspx");
                break;
                case "2":
                Response.Redirect("Consulta.aspx");
                break;
                case "3":
                Response.Redirect("Detalhes.aspx");
                break;
            }
        }
    }
}