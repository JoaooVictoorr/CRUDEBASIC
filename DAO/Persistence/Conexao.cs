using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class Conexao
   {
        //Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Abrir Conexão
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-9IGEOEE;Initial Catalog=master;Integrated Security=True");//ConectionString
                Con.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Fechar Conexão
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
   }
}
