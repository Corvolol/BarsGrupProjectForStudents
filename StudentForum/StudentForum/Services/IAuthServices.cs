namespace Web
{
    public interface IAuthServices
    {  /// <summary>
       /// Получение jwt токена по логину
       /// </summary>
       /// <param name="login">логин(email)пользователя</param>
       /// <returns></returns>
        string GenerateJWT(string login);

        string HashingPassword(string password);

        public User CreateUser(Registration registration);
    }
}
