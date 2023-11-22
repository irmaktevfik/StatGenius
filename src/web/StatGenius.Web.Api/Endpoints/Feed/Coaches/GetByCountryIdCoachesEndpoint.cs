using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Coaches;


[FastEndpoints.HttpGet("coaches/{countryId:int}"), AllowAnonymous]
public class GetByCountryIdCoachesEndpoint : Endpoint<GetCoachesRequest,GetAllCoachesResponse>
{
    private readonly ICoachesRepository _coachesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByCountryIdCoachesEndpoint(ICoachesRepository coachesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _coachesRepository = coachesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetCoachesRequest req, CancellationToken ct)
    {
        var bookmaker = await _coachesRepository.GetByCountryId(req.CountryId);
        if (bookmaker.Any())
        {
            var bookmakerResponse = _domainToApiContractMapper.ToCoachesResponse(bookmaker);
            await SendOkAsync(bookmakerResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}