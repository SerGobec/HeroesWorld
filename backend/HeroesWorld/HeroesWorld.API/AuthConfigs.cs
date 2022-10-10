using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace HeroesWorld.API
{
    public static class AuthConfigs
    {
        public const string ISSUER = "Sergobec"; // издатель токена
        public const string AUDIENCE = "https://localhost:7005/swagger/index.html"; // потребитель токена
        const string KEY = "SECRETKEYIWILLHIDEITDONTWORRY";   // ключ для шифрации
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
