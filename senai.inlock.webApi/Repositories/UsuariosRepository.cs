using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        /// <summary>
        /// Método para login do usuario 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        /// 
        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = inlock_games_manha; User Id = sa; Pwd = Senai@134";

        //public string StringConexao = "Data Source = LAPTOP-PNE5VUNU\\SQLEXPRESS; Initial Catalog = inlock_games_manha; Integrated Security = true";
        public UsuariosDomain Login(string email, string senha)
        {
            //string de conexão
            //using com sql conection e a query

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryLogin = "SELECT IdUsuario, Email, IdTipoUsuario FROM Usuario WHERE Email = @Email AND Senha =@password";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", senha);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuariosDomain usuario = new UsuariosDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                            Email = rdr["Email"].ToString(),
                            IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"])

                        };
                        return usuario;
                    }

                    return null;
                }
            }
        }
    }
}
