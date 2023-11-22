using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Coaches;

[FastEndpoints.HttpGet("fixtures/{id:int}"), AllowAnonymous]
public class GetByIdFixturesEndpoint : Endpoint<GetFixtureRequest,GetAllFixturesResponse>
{
    private readonly IFixturesRepository _fixturesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByIdFixturesEndpoint(IFixturesRepository fixturesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _fixturesRepository = fixturesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetFixtureRequest req, CancellationToken ct)
    {
        var fixtures = await _fixturesRepository.GetById(req.Id.Value);
        if (fixtures is not null)
        {
            var fixturesResponse = _domainToApiContractMapper.ToFixturesResponse(fixtures);
            await SendOkAsync(fixturesResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}