using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_De_Chamados
{

public static class SenhaHelper
    {
        // Gera hash + salt
        public static string GerarHashSenha(string senha)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(salt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Valida senha
        public static bool ValidarSenha(string senha, string hashSalvo)
        {
            byte[] hashBytes = Convert.FromBase64String(hashSalvo);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;
            }
            return true;
        }
    }

}

