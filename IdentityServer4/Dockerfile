FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["IdentityServer4/FhirIdentity.csproj", "IdentityServer4/"]
RUN dotnet restore "IdentityServer4/FhirIdentity.csproj"
COPY . .
WORKDIR "/src/IdentityServer4"
RUN dotnet build "FhirIdentity.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FhirIdentity.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FhirIdentity.dll"]