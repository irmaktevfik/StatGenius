using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Types;

[FastEndpoints.HttpGet("types"), AllowAnonymous]
public class GetAllTypesEndpoint : EndpointWithoutRequest<GetAllTypesResponse>
{
    private readonly ITypesRepository _typesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetAllTypesEndpoint(ITypesRepository typesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _typesRepository = typesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var types = await _typesRepository.GetAll();
        if (types is not null)
        {
            var customersResponse = _domainToApiContractMapper.ToTypesResponse(types);
            await SendOkAsync(customersResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}