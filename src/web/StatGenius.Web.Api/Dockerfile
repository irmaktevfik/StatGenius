FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/web/StatGenius.Web.Api/StatGenius.Web.Api.csproj", "src/web/StatGenius.Web.Api/"]
RUN dotnet restore "src/web/StatGenius.Web.Api/StatGenius.Web.Api.csproj"
COPY . .
WORKDIR "/src/src/web/StatGenius.Web.Api"
RUN dotnet build "StatGenius.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StatGenius.Web.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StatGenius.Web.Api.dll"]
