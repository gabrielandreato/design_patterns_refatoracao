FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RefactorationPt2/RefactorationPt2.csproj", "RefactorationPt2/"]
RUN dotnet restore "RefactorationPt2/RefactorationPt2.csproj"
COPY . .
WORKDIR "/src/RefactorationPt2"
RUN dotnet build "RefactorationPt2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RefactorationPt2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RefactorationPt2.dll"]
