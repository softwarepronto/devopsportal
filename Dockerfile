FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DevOpsPortal.csproj", "./"]
RUN dotnet restore "DevOpsPortal.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DevOpsPortal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevOpsPortal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevOpsPortal.dll"]
