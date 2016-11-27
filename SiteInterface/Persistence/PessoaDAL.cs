using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class PessoaDAL: Conexao
    {
        //Método para gravar dados: INSERT
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into TabelaPessoa(Nome, Endereco, Email) values ('"+p.Nome+"','"+p.Endereco+"', '"+p.Email+"')", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar a pessoa: " +ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para atualizar dados: UPDATE
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update TabelaPessoa set Nome = @v1, Endereco = @v2, Email = @v3 where Codigo = @v4", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("v4", p.Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar a pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para excluir dados: DELETE
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from TabelaPessoa where Codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir a pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para obter pessoa pelo código (chave primária): SELECT ESPECÍFICO
        public Pessoa ObterPessoaPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select Codigo, Nome, Endereco, Email from TabelaPessoa where Codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader();
                Pessoa p = new Pessoa();
                if(Dr.Read())
                {
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter a pessoa: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para listar todas as pessoas cadastradas: SELECT
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from TabelaPessoa", Con);
                Dr = Cmd.ExecuteReader();
                List<Pessoa> listaPessoa = new List<Pessoa>();
                while(Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                    listaPessoa.Add(p);
                }
                return listaPessoa;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar as pessoas: "+ ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
