FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

RUN dotnet publish apps/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:5055
ENV OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR=/data/domain-vector-dbs

EXPOSE 5055

ENTRYPOINT ["dotnet", "Outputs.Documents.Domain.VectorStore.McpServer.dll"]
CMD ["--transport", "stdio"]
