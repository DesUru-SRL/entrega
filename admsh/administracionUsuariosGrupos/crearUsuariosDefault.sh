#!/bin/bash
echo "Creando grupo Administrador..."
sudo groupadd administrador

echo "Creando usuario Administrador de BD..."
sudo useradd -m adminBD
#sudo passwd 
sudo usermod -G administrador adminBD

echo "Creando usuario Administrador de Servidores..."
sudo useradd -m adminServer
#sudo passwd adminServer
sudo usermod -G administrador adminServer

echo "Creando usuario Administrador de Usuarios..."
sudo useradd -m adminUser
#sudo passwd adminUser
sudo usermod -G administrador adminUser

echo
echo "Usuarios y grupos creados satisfactoriamente."
read -p "Aplaste ENTER para volver."

echo "[O] `date +'%F %T'`: Crear usuarios/grupos predeterminados" >> "`cat configuracion/ubicacionLog.conf`/audit.log"

