var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IAuthServices,AuthServices>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>((options) => { options.UseSqlServer(builder.Configuration.GetConnectionString("Default")!); });
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddSingleton<IAuthServices, AuthServices>();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateAudience = false,
            ValidateActor = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["key"])),
        };
    });
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();
app.UseAuthorization();
app.AddMinimalApiRoutes();
app.Run();
