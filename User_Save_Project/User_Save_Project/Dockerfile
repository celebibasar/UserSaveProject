#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["User_Save_Project/User_Save_Project.csproj", "User_Save_Project/"]
RUN dotnet restore "User_Save_Project/User_Save_Project.csproj"
COPY . .
WORKDIR "/src/User_Save_Project"
RUN dotnet build "User_Save_Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User_Save_Project.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User_Save_Project.dll"]
