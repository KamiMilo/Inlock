using BCrypt.Net;

namespace inlock_codefirst.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gerar uma Hash a partir de uma senha
        /// </summary>
        /// <param name="senha">senha que receberá a Hash</param>
        /// <returns>Senha Criptografada com a Hash</returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);

         }
        /// <summary>
        /// Verifica se a Hash da senha informada é a igual a hash que salva no Banco 
        /// </summary>
        /// <param name="senhaForm">senha informada pelo usúario</param>
        /// <param name="senhaBanco">senha cadastrada no banco</param>
        /// <returns>true ou false(senha é verdadeira?)</returns>

        public static bool CompararHash(string senhaForm, string senhaBanco) 
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
            
    }
}
