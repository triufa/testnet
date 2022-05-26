FROM mono:latest AS build-env

WORKDIR /app

COPY . .

RUN msbuild -t:restore

COPY . .

RUN nuget restore 

RUN msbuild MyProyectNet.sln

CMD [ "mono", "MyProyectNet.dll" ]