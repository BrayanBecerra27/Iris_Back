#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IrisBack/IrisBack.csproj", "IrisBack/"]
COPY ["IrisBusiness/IrisBusiness.csproj", "IrisBusiness/"]
COPY ["IrisCore/IrisCore.csproj", "IrisCore/"]
RUN dotnet restore "IrisBack/IrisBack.csproj"
COPY . .
WORKDIR "/src/IrisBack"
RUN dotnet build "IrisBack.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IrisBack.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IrisBack.dll"]
