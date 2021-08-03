FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SandboxApp1/SandboxApp1.csproj", "SandboxApp1/"]
RUN dotnet restore "SandboxApp1/SandboxApp1.csproj"
COPY . .
WORKDIR "/src/SandboxApp1"
RUN dotnet build "SandboxApp1.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "SandboxApp1.csproj" -c Debug -o /app/publish

FROM base AS final
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SandboxApp1.dll"]
