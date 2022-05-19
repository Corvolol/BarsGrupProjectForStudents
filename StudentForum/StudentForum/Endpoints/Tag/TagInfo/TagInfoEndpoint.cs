namespace Web.Endpoints.Tag.TagInfo
{
    public class TagInfoEndpoint : IEndpoint<IResult>
    {
        private HttpContext _context = default!;
        private int _tagId;
        private ITagRepository _tagRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/tag/info", async (HttpContext context, ITagRepository tagRepository) =>
            {
                _context = context;
                _tagRepository = tagRepository;
                return HandleAsync();
            })
              .WithTags("Tag")
              .Produces<TagInfoResponce>()
              .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync()
        {
            var tag = await _tagRepository.GetTag(_tagId);
            return Results.Ok(new TagInfoResponce()
            {
                name = tag.Name
            });
        }
    }
   
}
