using StatGenius.Common.DataObjects;

namespace StatGenius.Web.Api.Contracts.Responses;

public class GetAllTypesResponse
{
    public IEnumerable<TypesDto> Types { get; init; } = Enumerable.Empty<TypesDto>();
}