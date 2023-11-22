using FastEndpoints;
using FastEndpoints.Swagger;
using StatGenius.DataFeed.Models.Repository;
using StatGenius.DataFeed.Models.Repository.Implementation;
using StatGenius.Web.Api.Contracts.Responses;
using StatGenius.Web.Api.Mapping;
using StatGenius.Web.Api.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IBookmakersRepository, BookmakersRepository>();
builder.Services.AddScoped<ITypesRepository, TypesRepository>();
builder.Services.AddScoped<ICoachesRepository, CoachesRepository>();
builder.Services.AddScoped<IFixturesRepository, FixturesRepository>();
builder.Services.AddScoped<ICommentariesRepository, CommentariesRepository>();
builder.Services.AddSingleton<DomainToApiContractMapper>();

var app = builder.Build();
app.UseMiddleware<ValidationExceptionMiddleware>();
app.UseFastEndpoints(x =>
{
    x.Errors.ResponseBuilder = (failures, ctx, statusCode) =>
    {
        return new ValidationFailureResponse
        {
            Errors = failures.Select(y => y.ErrorMessage).ToList()
        };
    };
});


app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();

app.Run();