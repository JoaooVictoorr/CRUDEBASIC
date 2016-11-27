using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteInterface
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }
        protected void btnPesquisarPessoa(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL pd = new PessoaDAL();
                Pessoa p = pd.ObterPessoaPorCodigo(codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNomePessoaConsulta.Text = p.Nome;
                    txtEnderecoConsulta.Text = p.Endereco;
                    txtEmail.Text = p.Email;

                }
                   
            
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        protected void btnAtualizarConsulta(object sender, EventArgs e)
        {
            try
            {
                PessoaDAL pd = new PessoaDAL();
                Pessoa p = new DAL.Model.Pessoa();
                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = txtNomePessoaConsulta.Text;
                p.Endereco = txtEnderecoConsulta.Text;
                p.Email = txtEmail.Text;
                pd.Atualizar(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        protected void btnExcluirConsulta(object sender, EventArgs e)
        {
            try
            {
              PessoaDAL pd = new PessoaDAL();
              int codigo = Convert.ToInt32(txtCodigo.Text);
              pd.Excluir(codigo);                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }
    }
}
