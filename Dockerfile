FROM mcr.microsoft.com/dotnet/runtime:7.0-nanoserver-1809 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY [".net clone.csproj", "./"]
RUN dotnet restore ".net clone.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build ".net clone.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish ".net clone.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", ".net clone.dll"]
