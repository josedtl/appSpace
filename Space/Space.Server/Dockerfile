#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Space.Server/Space.Server.csproj", "Space.Server/"]
COPY ["Space.BusinessLayer/Space.BusinessLayer.csproj", "Space.BusinessLayer/"]
COPY ["Space.EntityLayer/Space.EntityLayer.csproj", "Space.EntityLayer/"]
COPY ["Space.DataLayer/Space.DataLayer.csproj", "Space.DataLayer/"]
COPY ["Framework/Framework.csproj", "Framework/"]
RUN dotnet restore "./Space.Server/Space.Server.csproj"
COPY . .
WORKDIR "/src/Space.Server"
RUN dotnet build "./Space.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Space.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Space.Server.dll"]