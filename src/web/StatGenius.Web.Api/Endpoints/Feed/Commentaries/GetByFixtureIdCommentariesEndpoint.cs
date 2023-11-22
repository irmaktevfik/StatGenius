using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Bookmakers;

[FastEndpoints.HttpGet("commentaries/fixture/{fixtureId:int}"), AllowAnonymous]
public class GetByFixtureIdCommentariesEndpoint  : Endpoint<GetCommentaryRequest,GetAllCommentariesResponse>
{
    private readonly ICommentariesRepository _commentariesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByFixtureIdCommentariesEndpoint(ICommentariesRepository commentariesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _commentariesRepository = commentariesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetCommentaryRequest req, CancellationToken ct)
    {
        var commentaries = await _commentariesRepository.GetByFixtureId(req.FixtureId);
        if (commentaries.Any())
        {
            var commentariesResponse = _domainToApiContractMapper.ToCommentariesResponse(commentaries);
            await SendOkAsync(commentariesResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}