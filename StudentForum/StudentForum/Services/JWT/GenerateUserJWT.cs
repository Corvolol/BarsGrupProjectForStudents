namespace Web
{
    public class GenerateUserJWT : IGenerateUserJWT
    {
        private IConfiguration _iConfigeration { get; }
        public GenerateUserJWT(IConfiguration iConfiguration)
        {
            _iConfigeration = iConfiguration;
        }
        /// <summary>
        /// Получение jwt токена по логину
        /// </summary>
        /// <param name="login">логин(email)пользователя</param>
        /// <returns></returns>
        public string GenerateJWT(string login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_iConfigeration["key"]!);
            var jwtDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", login) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateJwtSecurityToken(jwtDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
