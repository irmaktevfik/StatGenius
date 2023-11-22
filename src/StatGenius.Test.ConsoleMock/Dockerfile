FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/StatGenius.Test.ConsoleMock/StatGenius.Test.ConsoleMock.csproj", "src/StatGenius.Test.ConsoleMock/"]
RUN dotnet restore "src/StatGenius.Test.ConsoleMock/StatGenius.Test.ConsoleMock.csproj"
COPY . .
WORKDIR "/src/src/StatGenius.Test.ConsoleMock"
RUN dotnet build "StatGenius.Test.ConsoleMock.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StatGenius.Test.ConsoleMock.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StatGenius.Test.ConsoleMock.dll"]
