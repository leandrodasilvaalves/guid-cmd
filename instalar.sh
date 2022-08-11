#!/bin/bash

echo "Inicando build..."
dotnet build src/GuidCmd/ -c release -o guid

echo "Preparando o pacote..."
mv ./guid/GuidCmd.exe ./guid/guid.exe

echo "Removendo versao obsoleta..."
rm -rf /c/guid/

echo "Instalando nova versao..."
mkdir /c/guid/
cp -r ./guid/* /c/guid/
ls -la /c/guid/

echo "Removendo artefados de build..."
rm -rf ./guid/

echo "Instalacao finalizada com sucesso."