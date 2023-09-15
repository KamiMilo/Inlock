using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace senai.inlock.webApi.Repositories
{
    public class JogosRepository : IjogosRepository
    {

        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = inlock_games_manha; User Id = sa; Pwd = Senai@134";

        //public string StringConexao = "Data Source = LAPTOP-PNE5VUNU\\SQLEXPRESS; Initial Catalog = inlock_games_manha; Integrated Security = true";

        /// <summary>
        /// Método para cadastrar um novo Jogo
        /// </summary>
        /// <param name="NovoJogo"></param>
        /// <exception cref="NotImplementedException"></exception>
        /// 

        public void Cadastrar(JogosDomain NovoJogo)
        {
            //Declara a conexão
            using(SqlConnection con = new SqlConnection())
            {
                //query com o comando
                string queryInsert = "INSERT INTO Jogo(IdEstudio,Nome,Descricao,DataLancamento,Valor) VALUES (@idestudio,@Nome,@Descricao,@DataLancamento,@Valor)";

                con.Open();

                //declara a sqlcommand passando a query e a sqlconection como parametro
                using(SqlCommand cmd = new SqlCommand(queryInsert,con))
                {
                    //passa o valor dos parametros
                    cmd.Parameters.AddWithValue("IdEstudio", NovoJogo.IdEstudio);
                    cmd.Parameters.AddWithValue("Nome", NovoJogo.Nome);
                    cmd.Parameters.AddWithValue("Descricao", NovoJogo.Descricao);
                    cmd.Parameters.AddWithValue("DataLancamento", NovoJogo.DataDeLacamento);
                    cmd.Parameters.AddWithValue("Valor", NovoJogo.Valor);

                    //executa a query
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <summary>
        /// método para deletar um jogo passando seu id.
        /// </summary>
        /// <param name="Id"></param>
        public void Deletar(int Id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                string queryDelete = "DELETE FROM Jogo WHERE IdJogo = @IdBuscado";

                con.Open();

                using(SqlCommand cmd = new SqlCommand(queryDelete ,con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método para listar os jogos existentes no banco de dados.
        /// </summary>
        /// <returns>Lista de Jogos</returns>
        /// <exception cref="NotImplementedException"></exception>

        public List<JogosDomain> ListarTodos()
        {
            List<JogosDomain> listaDeJogos = new List<JogosDomain>();

            using(SqlConnection conbd= new SqlConnection(StringConexao))
            {
               
                 string QueryList = "SELECT Jogo.Nome AS Jogo ,Estudio.Nome AS Estudio FROM Jogo INNER JOIN Estudio ON Jogo.IdEstudio = Estudio.IdEstudio;";

                conbd.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand (QueryList,conbd) )
                {
                   rdr= cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogosDomain NovoJogo = new JogosDomain()
                        {
                            Nome = rdr["Jogo"].ToString(),
                        };

                        EstudiosDomain novoEstudio = new EstudiosDomain()
                        {
                            Nome = rdr["Estudio"].ToString()
                        };

                        listaDeJogos.Add(NovoJogo);
                    }
                 

                }

            }

                return listaDeJogos;
        } //*
    }
}
