using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Coaches;

[FastEndpoints.HttpGet("coaches/{id:int}"), AllowAnonymous]
public class GetByIdCoachesEndpoint : Endpoint<GetCoachesRequest,GetCoachResponse>
{
    private readonly ICoachesRepository _coachesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByIdCoachesEndpoint(ICoachesRepository coachesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _coachesRepository = coachesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetCoachesRequest req, CancellationToken ct)
    {
        var coach = await _coachesRepository.GetById(req.Id);
        if (coach is not null)
        {
            var coachResponse = _domainToApiContractMapper.ToCoachesResponse(coach);
            await SendOkAsync(coachResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}