namespace Web.Endpoints.Tag.GetAllTag
{
    public class GetAllTagEndpoint : IEndpoint<IResult>
    {
        public Dictionary<int, string>? IdName { get; set; }

        private ITagRepository _tagRepository = default!;
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/get-all-tags", async (ITagRepository repository) =>
            {
                _tagRepository = repository;
                return await HandleAsync();
            })
              .WithTags("Tag")
              .Produces<GetAllTagResponce>();
           
        }

        public async Task<IResult> HandleAsync()
        {
 
            var tag = await _tagRepository.GetAllTag();
            var responce = new GetAllTagResponce() { ListTag = tag.Select(x => new PairTagIdName() { Id = x.Id, Name = x.Name }).ToList() };

            return Results.Ok(responce);
        }
    }
}
