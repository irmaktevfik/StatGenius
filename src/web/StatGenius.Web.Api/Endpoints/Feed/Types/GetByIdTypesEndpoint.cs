using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Requests;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;

namespace StatGenius.Web.Api.Endpoints.Feed.Types;

[FastEndpoints.HttpGet("types/{id:int}"), AllowAnonymous]
public class GetByIdTypesEndpoint : Endpoint<GetTypeRequest,GetTypeResponse>
{
    private readonly ITypesRepository _typesRepository;
    private readonly DomainToApiContractMapper _domainToApiContractMapper;

    public GetByIdTypesEndpoint(ITypesRepository typesRepository,
        DomainToApiContractMapper domainToApiContractMapper)
    {
        _typesRepository = typesRepository;
        _domainToApiContractMapper = domainToApiContractMapper;
    }

    public override async Task HandleAsync(GetTypeRequest req, CancellationToken ct)
    {
        var types = await _typesRepository.GetById(req.Id);
        if (types is not null)
        {
            var customersResponse = _domainToApiContractMapper.ToTypesResponse(types);
            await SendOkAsync(customersResponse, ct);
        }
        else
            await SendNotFoundAsync();    
    }
}