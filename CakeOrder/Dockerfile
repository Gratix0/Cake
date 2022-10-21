FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CakeOrder/CakeOrder.csproj", "CakeOrder/"]
RUN dotnet restore "CakeOrder/CakeOrder.csproj"
COPY . .
WORKDIR "/src/CakeOrder"
RUN dotnet build "CakeOrder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CakeOrder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CakeOrder.dll"]
