FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RefactorationPt3/RefactorationPt3.csproj", "RefactorationPt3/"]
RUN dotnet restore "RefactorationPt3/RefactorationPt3.csproj"
COPY . .
WORKDIR "/src/RefactorationPt3"
RUN dotnet build "RefactorationPt3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RefactorationPt3.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RefactorationPt3.dll"]
