FROM microsoft/dotnet
WORKDIR /app
COPY . .
ENTRYPOINT ["dotnet", "Sample-Istio-Review.dll"]