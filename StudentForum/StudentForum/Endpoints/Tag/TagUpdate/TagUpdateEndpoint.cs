namespace Web.Endpoints.Tag.TagUpdate
{
    public class TagUpdateEndpoint : IEndpoint<IResult, TagUpdateRequest>
    {
        private HttpContext _context = default!;
        private ITagRepository _tagRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPut("/tag/update", async (TagUpdateRequest tagUpdateRequest, HttpContext context, ITagRepository tagRepository) =>
            {
                _context = context;
                _tagRepository = tagRepository;
                return HandleAsync(tagUpdateRequest);
            }).WithTags("Tag")
                .Produces(StatusCodes.Status200OK)
                .RequireAuthorization();
        }

        public async Task<IResult> HandleAsync(TagUpdateRequest tagupdaterequest)
        {
            var tag = new TagModel()
            {
                TagId = tagupdaterequest.TagId,
                 name= tagupdaterequest.name
            };
            await _tagRepository.UpdateTag(tag);
            return Results.Ok();
        }
    }
}
