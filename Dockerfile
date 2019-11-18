FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY . .
VOLUME ["/app/wwwroot"]
VOLUME ["/app/App_Data"]
ENTRYPOINT ["dotnet", "AdAlliance.Web.Host.dll"]