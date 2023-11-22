using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Coaches;

[FastEndpoints.HttpGet("fixtures"), AllowAnonymous]
public class GetAllFixturesEndpoint : EndpointWithoutRequest<GetAllFixturesResponse>
{
    private readonly IFixturesRepository _fixturesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetAllFixturesEndpoint(IFixturesRepository fixturesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _fixturesRepository = fixturesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var fixtures = await _fixturesRepository.GetAll();
        if (fixtures.Any())
        {
            var fixturesResponse = _domainToApiContractMapper.ToFixturesResponse(fixtures);
            await SendOkAsync(fixturesResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}