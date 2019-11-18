dotnet restore
dotnet build
dotnet publish -c:Release -o /home/projects/mysqlweb/publish
cd publish
docker login -u clementgao -p clement@@8767
docker build -t mysqlweb .
docker push clementgao/mysqlweb:latest