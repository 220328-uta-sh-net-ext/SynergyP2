#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GrowthAPI/GrowthAPI.csproj", "GrowthAPI/"]
COPY ["GrowthBL/GrowthBL.csproj", "GrowthBL/"]
COPY ["GrowthModels/GrowthModels.csproj", "GrowthModels/"]
COPY ["GrowthDL_2/GrowthDL.csproj", "GrowthDL_2/"]
COPY ["UnitTesting/UnitTesting.csproj", "UnitTesting/"]
RUN dotnet restore "GrowthAPI/GrowthAPI.csproj"
COPY . .
WORKDIR "/src/GrowthAPI"
RUN dotnet build "GrowthAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrowthAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrowthAPI.dll"]