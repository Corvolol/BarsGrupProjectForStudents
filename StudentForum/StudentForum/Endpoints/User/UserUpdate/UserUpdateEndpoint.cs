namespace Web.Endpoints.User.UserUpdate
{
    public class UserUpdateEndpoint : IEndpoint<IResult, UserUpdateRequest>
    {
       
        private HttpContext _context = default!;
        private IUserRepository _userRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPut("/user/update", async (UserUpdateRequest userUpdateRequest,HttpContext context,IUserRepository userRepository) =>
             {
                 _context = context;
                 _userRepository = userRepository;
                 return await  HandleAsync(userUpdateRequest);
             }).WithTags("User")
                .Produces<UserUpdateResponce>()
                .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(UserUpdateRequest userUpdateRequest)
        {
            var user = new UserModel()
            {
                Name = userUpdateRequest.Name,
                LastName = userUpdateRequest.LastName,
                NickName = userUpdateRequest.NickName,
                Faculty = userUpdateRequest.Faculty,
                Groupnumber = userUpdateRequest.Groupnumber,
                Speciality = userUpdateRequest.Speciality
            };
            await _userRepository.UpdateUser(user);
            return Results.Ok(new UserUpdateResponce() { Succes = true});
        }
    }
}
