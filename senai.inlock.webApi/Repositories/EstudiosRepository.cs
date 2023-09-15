using Microsoft.AspNetCore.Mvc.Diagnostics;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {
        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = inlock_games_manha; User Id = sa; Pwd = Senai@134";

        //public string StringConexao = "Data Source = LAPTOP-PNE5VUNU\\SQLEXPRESS; Initial Catalog = inlock_games_manha; Integrated Security = true";
        public void Cadastrar(EstudiosDomain novoEstudio)
        {

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryInsert = "INSERT INTO Estudio (Nome) VALUES (@Nome)";


                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

                    con.Open();

                    cmd.ExecuteNonQuery();

                }

            }
        }

        public List<EstudiosDomain> ListarTodos()
        {
            List<EstudiosDomain> ListarEstudios = new List<EstudiosDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelectAll = "SELECT IdEstudio,Nome FROM Estudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(QuerySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudiosDomain novoEstudio = new EstudiosDomain()
                        {

                            IdEstudio = Convert.ToInt32(rdr[("IdEstudio")]),

                            Nome = rdr["Nome"].ToString()
                        };

                        ListarEstudios.Add(novoEstudio);

                    }


                }

            }
            return ListarEstudios;

        }

        public void Deletar(int id)

        { using (SqlConnection conn = new SqlConnection (StringConexao))
            {
                string queryDelete = "DELETE FROM Estudio WHERE IdEstudio = IdEstudio ,Nome = Nome";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("IdEstudio", id);

                    cmd.ExecuteNonQuery();
                }
            }


        }
    }
}
