FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY VisitsApi.csproj .
RUN dotnet restore VisitsApi.csproj
COPY . .
RUN dotnet build VisitsApi.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish VisitsApi.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VisitsApi.dll"]
