namespace Web.Endpoints.User.Registration
{
    public class RegistrarionEndpoint : IEndpoint<IResult, RegistrationRequest>
    {
        private IGenerateUserJWT _generateUserJWT = default!;
        private IUserRepository _userRepostiroty = default!;
        private IHashingPassword _hashingPassword = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/registration", async (RegistrationRequest registrationRequest, IGenerateUserJWT generateUserJWT, IUserRepository userRepostiroty, IHashingPassword hashingPassword) =>
            {
                _generateUserJWT = generateUserJWT;
                _userRepostiroty = userRepostiroty;
                _hashingPassword = hashingPassword;
                return await HandleAsync(registrationRequest);
            })
             .WithTags("User")
             .Produces<RegistrationResponce>();
        }

        public async Task<IResult> HandleAsync(RegistrationRequest registrationRequest)
        {
            if (await _userRepostiroty.GetUser(registrationRequest.Email) == null)
            {
                registrationRequest.Password = _hashingPassword.Hashing(registrationRequest.Password);
                string token = _generateUserJWT.GenerateJWT(registrationRequest.Email);
                UserModel user =    new UserModel()
                {
                    Email = registrationRequest.Email,
                    Password = registrationRequest.Password,
                    Name = registrationRequest.Name,
                    LastName = registrationRequest.LastName,
                    NickName = registrationRequest.NickName,
                    Faculty = registrationRequest.Faculty,
                    Groupnumber = registrationRequest.Groupnumber,
                    Speciality = registrationRequest.Speciality
                }; 
                await _userRepostiroty.AddUSer(user);
                return Results.Ok(new RegistrationResponce() { Token = token , Username = registrationRequest.NickName });
            }
            return Results.BadRequest();
        }
    }
}
