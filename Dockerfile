FROM mcr.microsoft.com/dotnet/nightly/sdk:latest AS build
WORKDIR /app

COPY *.sln .
COPY SelfMadeDB/*.csproj ./SelfMadeDB/
RUN dotnet restore ./SelfMadeDB/*.csproj

COPY SelfMadeDB/. ./SelfMadeDB/
WORKDIR /app/SelfMadeDB
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/nightly/aspnet:latest AS runtime
WORKDIR /app
COPY --from=build /app/SelfMadeDB/out ./
ENTRYPOINT ["dotnet", "SelfMadeDB.dll"]
EXPOSE 80