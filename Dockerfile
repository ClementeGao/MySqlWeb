FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
WORKDIR /dev
EXPOSE 5000
EXPOSE 80
# EXPOSE 443
COPY . .
VOLUME ["/app/wwwroot"]
VOLUME ["/app/App_Data"]
ENTRYPOINT ["dotnet", "MySql.Web.dll"]