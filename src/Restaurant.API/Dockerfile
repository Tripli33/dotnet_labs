FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Restaurant.API/Restaurant.API.csproj", "src/Restaurant.API/"]
COPY ["src/Restaurant.BLL/Restaurant.BLL.csproj", "src/Restaurant.BLL/"]
COPY ["src/Restaurant.DAL/Restaurant.DAL.csproj", "src/Restaurant.DAL/"]
RUN dotnet restore "src/Restaurant.API/Restaurant.API.csproj"
COPY . .
WORKDIR "/src/src/Restaurant.API"
RUN dotnet build "Restaurant.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Restaurant.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Restaurant.API.dll"]
