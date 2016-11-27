using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
namespace SiteInterface
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaDAL pd = new PessoaDAL();
                gridPessoas.DataSource = pd.Listar(); // Comando para pupular Grid
                gridPessoas.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}