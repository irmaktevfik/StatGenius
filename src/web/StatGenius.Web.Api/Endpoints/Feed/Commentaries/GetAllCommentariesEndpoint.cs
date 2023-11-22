using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Bookmakers;

[FastEndpoints.HttpGet("commentaries"), AllowAnonymous]
public class GetAllCommentariesEndpoint : EndpointWithoutRequest<GetAllCommentariesResponse>
{
    private readonly ICommentariesRepository _commentariesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetAllCommentariesEndpoint(ICommentariesRepository commentariesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _commentariesRepository = commentariesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var commentaries = await _commentariesRepository.GetAll();
        if (commentaries.Any())
        {
            var commentariesResponse = _domainToApiContractMapper.ToCommentariesResponse(commentaries);
            await SendOkAsync(commentariesResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}