namespace Web
{
    public interface IGenerateUserJWT
    {  /// <summary>
       /// Получение jwt токена по логину
       /// </summary>
       /// <param name="login">логин(email)пользователя</param>
       /// <returns></returns>
        string GenerateJWT(string login);
    }
}
