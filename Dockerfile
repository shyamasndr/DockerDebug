FROM microsoft/dotnet:latest

RUN apt-get update

RUN apt-get install -y wget unzip

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l ~/vsdbg

COPY ./publish /app

WORKDIR /app

ENTRYPOINT ./jsonfile
