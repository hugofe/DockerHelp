#oficial python image
FROM python:do3.7.2-slim
#diretorio raiz padrão
WORKDIR /app
#copy the current diretory content into the container.
ADD . /app
#instala todas as dependencia especificadas no requirements.txt
RUN pip install --trusted-host pypi.python.org -r requirements.txt
#torna a porta padrão 80 do container para fora
EXPOSE 80
#Define o variavel de ambiente
ENV NAME World
#Roda o arquivo app.py quando o container inicia
CMD ["python" , "app.py"]