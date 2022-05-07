namespace Web
{
    public interface IAuthServices
    {
        string GenerateJWT(string login);
    }
}
