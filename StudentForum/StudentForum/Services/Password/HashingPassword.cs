namespace Web.Services
{
    public class HashingPassword:IHashingPassword
    {
        private IConfiguration _iConfigeration { get; }
        public HashingPassword(IConfiguration iConfiguration)
        {
            _iConfigeration = iConfiguration;
        }
        public string Hashing(string password)
        {
            Encoding encoding = Encoding.UTF8;
            string solt = _iConfigeration["solt"]!;
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: encoding.GetBytes(solt),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
