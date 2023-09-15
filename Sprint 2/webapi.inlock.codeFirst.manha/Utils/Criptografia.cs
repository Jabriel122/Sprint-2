namespace webapi.inlock.codeFirst.manha.Utils
{
    public class Criptografia
    {
        /// <summary>
        /// Gerar uma hash a partir de uma senha 
        /// </summary>
        /// <param name="senha">Senha que receberá a Hash</param>
        /// <returns>>Senah criptografada com hash</returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }


        /// <summary>
        /// Verificar se a hash da senha informada é igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm">Senha informada pelo o usuário</param>
        /// <param name="senhaBanco"> Senha cadastrada no banco </param>
        /// <returns>True ou False (senha é verdadeira)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);

        }
        

    }
}
