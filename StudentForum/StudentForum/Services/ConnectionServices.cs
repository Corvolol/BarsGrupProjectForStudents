namespace Web.Services
{
    public static class ConnectionServices
    {
        public static IServiceCollection AddConnectionServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddSingleton<IGenerateUserJWT, GenerateUserJWT>();
            services.AddSingleton<IHashingPassword, HashingPassword>();
            return services;
        }
    }
}
