using AutoMapper;
using StatGenius.Web.Api.Helpers;

namespace StatGenius.Web.Api.Mapping;

public class BaseMapper
{
    protected IMapper _mapper;

    public BaseMapper()
    {
        _mapper = new Mapper(MapperConfig.GetMapperConfig());
    }
}