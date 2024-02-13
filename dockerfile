FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app
COPY ./src/HelloDocker.Terminal/HelloDocker.Terminal.csproj ./
RUN dotnet restore .
COPY src/HelloDocker.Terminal/. ./
RUN dotnet publish -o pub -c Release

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS production-env
ENV SERVE_STATUS=default

WORKDIR /etc/HelloDocker/.
COPY --from=build-env /app/pub .
ENTRYPOINT ["dotnet" , "HelloDocker.Terminal.dll"]