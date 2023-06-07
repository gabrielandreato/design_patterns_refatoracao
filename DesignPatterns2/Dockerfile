FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DesignPatterns2/DesignPatterns2.csproj", "DesignPatterns2/"]
RUN dotnet restore "DesignPatterns2/DesignPatterns2.csproj"
COPY . .
WORKDIR "/src/DesignPatterns2"
RUN dotnet build "DesignPatterns2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPatterns2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPatterns2.dll"]
