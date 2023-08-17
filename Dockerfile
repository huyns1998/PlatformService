FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

# Copy everything
COPY PlatformService/* ./
RUN dotnet restore

COPY . ./
COPY docker.dcproj ./docker-compose.dcproj
RUN dir
RUN dotnet publish PlatformService.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "PlatformService.dll", "--environment=Development"]