namespace Web
{
    public class AuthServices : IAuthServices
    {
        private IConfiguration _iConfigeration { get; }
        public AuthServices(IConfiguration iConfiguration)
        {
            _iConfigeration = iConfiguration;
        }
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
