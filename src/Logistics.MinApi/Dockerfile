#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Logistics.MinApi/Logistics.MinApi.csproj", "src/Logistics.MinApi/"]
RUN dotnet restore "src/Logistics.MinApi/Logistics.MinApi.csproj"
COPY . .
WORKDIR "/src/src/Logistics.MinApi"
RUN dotnet build "Logistics.MinApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logistics.MinApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logistics.MinApi.dll"]