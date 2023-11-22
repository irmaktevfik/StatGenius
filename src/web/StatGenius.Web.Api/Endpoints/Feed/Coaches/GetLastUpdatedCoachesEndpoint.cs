using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Coaches;

[FastEndpoints.HttpGet("coaches/lastupdated"), AllowAnonymous]
public class GetLastUpdatedCoachesEndpoint :  EndpointWithoutRequest<GetAllCoachesResponse>
{
    private readonly ICoachesRepository _coachesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetLastUpdatedCoachesEndpoint(ICoachesRepository coachesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _coachesRepository = coachesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var coaches = await _coachesRepository.GetLastUpdated();
        if (coaches.Any())
        {
            var coachesResponse = _domainToApiContractMapper.ToCoachesResponse(coaches);
            await SendOkAsync(coachesResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}