using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Bookmakers;

[FastEndpoints.HttpGet("bookmakers/{id:int}"), AllowAnonymous]
public class GetByIdBookmakersEndpoint : Endpoint<GetBookmakerRequest,GetBookmakersResponse>
{
    private readonly IBookmakersRepository _bookmakersRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByIdBookmakersEndpoint(IBookmakersRepository bookmakersRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _bookmakersRepository = bookmakersRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetBookmakerRequest req, CancellationToken ct)
    {
        var bookmaker = await _bookmakersRepository.GetId(req.Id);
        if (bookmaker is not null)
        {
            var bookmakerResponse = _domainToApiContractMapper.ToBookmakersResponse(bookmaker);
            await SendOkAsync(bookmakerResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}