var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CORSPolicy",
//        builder =>
//        {
//            builder
//            .AllowAnyMethod()
//            .AllowAnyHeader()
//            .WithOrigins("https://localhost:3006");
//        });
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<Context>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            options => options.MigrationsAssembly("Web")));
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["key"])),
        };
    });
builder.Services.AddEndpoints();
builder.Services.AddConnectionServices();
builder.Services.AddCustomSwagger();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseCors("CORSPolicy");
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapEndpoints();
app.Run();
