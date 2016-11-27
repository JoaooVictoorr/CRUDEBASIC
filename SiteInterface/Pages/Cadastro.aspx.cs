using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Persistence;
using DAL.Model;



namespace SiteInterface
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrar(object sender, EventArgs e)
        {   //Gravando Nome da pessoa no banco
            Pessoa p = new Pessoa();
            PessoaDAL pd = new PessoaDAL();
            p.Nome = txtPessoaNome.Text;
            p.Endereco = txtEnderecoPessoa.Text;
            p.Email = txtEmail.Text;
            pd.Gravar(p);
        }

    }
}