﻿namespace Web.Endpoints.User.UserDelete
{
    public class UserDeleteEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private IUserRepository _userRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapDelete("/user/delete", async (HttpContext context, IUserRepository userRepository) =>
            {
                _context = context;
                _userRepository = userRepository;
                return await HandleAsync();
            }).WithTags("User")
              .Produces<UserDeleteResponce>()
              .RequireAuthorization();
        }
        public async Task<IResult> HandleAsync()
        {
            await _userRepository.DeleteUser(_context.User.Claims.ToArray()[0].Value);
            return Results.Ok(new UserDeleteResponce() { Succes = true });
        }
    }
}
