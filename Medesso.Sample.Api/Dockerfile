FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Medesso.Sample.Api/Medesso.Sample.Api.csproj", "Medesso.Sample.Api/"]
RUN dotnet restore "Medesso.Sample.Api/Medesso.Sample.Api.csproj"
COPY . .
WORKDIR "/src/Medesso.Sample.Api"
RUN dotnet build "Medesso.Sample.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Medesso.Sample.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Medesso.Sample.Api.dll"]
