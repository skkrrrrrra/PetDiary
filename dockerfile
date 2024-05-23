FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
COPY . .
RUN dotnet restore "src/PetDiary.Web/PetDiary.Web.csproj"
COPY . .
WORKDIR /src
RUN dotnet build "PetDiary.Web/PetDiary.Web.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "PetDiary.Web/PetDiary.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PetDiary.Web.dll"]