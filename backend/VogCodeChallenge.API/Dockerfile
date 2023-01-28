FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS clean
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VogCodeChallenge.API/VogCodeChallenge.API.csproj", "VogCodeChallenge.API/"]
RUN dotnet restore "VogCodeChallenge.API/VogCodeChallenge.API.csproj"
COPY . .
WORKDIR "/src/VogCodeChallenge.API"
RUN dotnet build "VogCodeChallenge.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VogCodeChallenge.API.csproj" -c Release -o /app/publish

FROM clean AS ready
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VogCodeChallenge.API.dll"]