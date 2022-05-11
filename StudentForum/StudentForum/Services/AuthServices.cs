namespace Web
{
    public class AuthServices : IAuthServices
    {
        private IConfiguration _iConfigeration { get; }
        public AuthServices(IConfiguration iConfiguration)
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

        public string HashingPassword(string password)
        {
            Encoding encoding =  Encoding.UTF8;
            string solt = _iConfigeration["solt"]!;
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: encoding.GetBytes(solt),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
            return hashed;
        }
        public User CreateUser(Registration registration)
        {
            return new User
            {
                Email = registration.Email,
                Password = registration.Password,
                Name = registration.Name,
                LastName = registration.LastName,
                NickName = registration.NickName,
                Faculty = registration.Faculty,
                Groupnumber = registration.Groupnumber,
                Speciality= registration.Speciality
            };
        }
    }
}
