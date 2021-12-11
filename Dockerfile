FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /source

COPY *.sln .
COPY BlazorApp1/*.csproj ./BlazorApp1/
RUN dotnet restore

COPY BlazorApp1/. ./BlazorApp1/
WORKDIR /source/BlazorApp1
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/core/aspnet:5
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "BlazorApp1.dll"]
