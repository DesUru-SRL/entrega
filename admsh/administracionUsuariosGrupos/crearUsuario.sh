#!/bin/bash
read -p "Ingrese nombre de usuario: " nombre
sudo useradd -m $nombre
if [ "$?" != "0" ]; then
	echo "Se ha producido un error."
	read -p "Aplaste ENTER para volver."
	echo "[X] `date +'%F %T'`: Crear usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
	sudo passwd $nombre
	echo "Usuario $nombre creado satisfactoriamente."
	read -p "Aplaste ENTER para volver."
	echo "[O] `date +'%F %T'`: Crear usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
