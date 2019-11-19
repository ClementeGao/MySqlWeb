dotnet restore
dotnet build
dotnet publish -c:Release -o /home/projects/mysqlweb/publish
cd publish
docker login -u clementgao -p clement@@8767
docker rmi $(docker images -f “dangling=true” -q)
docker rmi `docker images | grep "<none>" | awk '{print $3}'`
docker rmi -f clementgao/mysqlweb
docker build -t clementgao/mysqlweb .
#docker push clementgao/mysqlweb:latest