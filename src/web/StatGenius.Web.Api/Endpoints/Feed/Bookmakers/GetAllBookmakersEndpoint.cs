using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Bookmakers;

[FastEndpoints.HttpGet("bookmakers"), AllowAnonymous]
public class GetAllBookmakersEndpoint : EndpointWithoutRequest<GetAllBookmakersResponse>
{
    private readonly IBookmakersRepository _bookmakersRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetAllBookmakersEndpoint(IBookmakersRepository bookmakersRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _bookmakersRepository = bookmakersRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var bookmakers = await _bookmakersRepository.GetAll();
        if (bookmakers.Any())
        {
            var bookmakersResponse = _domainToApiContractMapper.ToBookmakersResponse(bookmakers);
            await SendOkAsync(bookmakersResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}