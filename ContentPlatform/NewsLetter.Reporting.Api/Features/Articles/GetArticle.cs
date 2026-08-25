using Carter;
using MediatR;
using Newsletter.Api.Shared;
using Newsletter.Reporting.Api.Database;
using NewsLetter.Reporting.Api.Entities;

namespace NewsLetter.Reporting.Api.Features.Articles;

public static class GetArticle
{
    public class Query : IRequest<Result<ArticleResponse>>
    {
        public Guid Id { get; set; }
    }

    internal sealed class Handler : IRequestHandler<Query, Result<ArticleResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public async Task<Result<ArticleResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            //var articleResponse;

            //if (articleResponse is null)

            //return articleResponse;


        }
    }
}

public class GetArticleEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("", () =>
        {
            // return NotFound

            //return.Results.Ok();
        });
    }
}

public class ArticleResponse
{
    public Guid Id { get; set; }
    public DateTime CreatedOnUtc { get; set; }

    public Guid PublishedOnUtc { get; set; }

    public List<ArticleEventResponse> Events { get; set; } = new();
}

public class ArticleEventResponse
{
    public Guid Id { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public ArticleEventType EventType { get; set; }
}
