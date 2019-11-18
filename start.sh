#!/bin/sh
cd /home/projects/mysqlweb
dotnet publish -c:Release -o /home/projects/mysqlweb/publish
cd /home/projects/mysqlweb/publish
docker login -u clementgao -p clement@@8767
docker build -t mysqlweb .
docker push clementgao/mysqlweb:lastest