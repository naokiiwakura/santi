# NuGet restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY Santi.Api/*.csproj Santi.Api/
COPY Santi.Domain/*.csproj Santi.Domain/
COPY Santi.Repository/*.csproj Santi.Repository/
COPY Santi.Service/*.csproj Santi.Service/
RUN dotnet restore
COPY . .

# testing
FROM build AS testing
WORKDIR /src/Santi.Api
RUN dotnet build


# publish
FROM build AS publish
WORKDIR /src/Santi.Api
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "Santi.Api.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Santi.Api.dll