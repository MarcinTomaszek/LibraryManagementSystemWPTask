FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["LibraryManagementSystemWPTask/LibraryManagementSystemWPTask.csproj", "LibraryManagementSystemWPTask/"]
RUN dotnet restore "LibraryManagementSystemWPTask/LibraryManagementSystemWPTask.csproj"
COPY . .
WORKDIR "/src/LibraryManagementSystemWPTask"
RUN dotnet build "LibraryManagementSystemWPTask.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "LibraryManagementSystemWPTask.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryManagementSystemWPTask.dll"]
