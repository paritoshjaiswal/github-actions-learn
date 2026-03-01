# Use the official .NET 10 SDK as build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY ["01-app-dotnet.csproj", "./"]
RUN dotnet restore "01-app-dotnet.csproj"

# copy everything else and build
COPY . ./
RUN dotnet publish "01-app-dotnet.csproj" -c Release -o /app/publish

# runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./

# expose port
EXPOSE 80
ENTRYPOINT ["dotnet", "01-app-dotnet.dll"]
