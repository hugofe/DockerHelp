#Busca a imagem do repositorio
FROM microsoft/dotnet:2.1-sdk
#criar a pasta app e torna ela como pasta raiz do container
WORKDIR /app
# copia o arquivo csproj para o a pasta raiz, neste caso /app
COPY *.csproj ./
#baixa as dependencias do projeto
RUN dotnet restore
#copia todos os arquivos do arquivo raiz do projeto para a raiz do docker
COPY . ./
#Compila o projeto .net
RUN dotnet publish -c Release -o publicado
RUN ls -al
ENTRYPOINT [ "dotnet" , "publicado/AulaDocker.dll" ]