FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Getway.API/Getway.API.csproj", "Getway.API/"]
RUN dotnet restore "Getway.API/Getway.API.csproj"
COPY . .
WORKDIR "/src/Getway.API"
RUN dotnet build "Getway.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Getway.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Getway.API.dll"]
