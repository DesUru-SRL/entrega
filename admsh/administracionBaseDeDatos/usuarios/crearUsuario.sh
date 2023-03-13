#!/bin/bash
read -p "ingrese el nombre de usuario a agregar " nombre
	sudo useradd -m $nombre 
	sudo passwd $nombre
echo "GRANT CONNECT TO $nombre" > administracionBaseDeDatos/comando.sql
dbaccess desuru@demo_on administracionBaseDeDatos/comando.sql
rm comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Crear usuario BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "Usuario $nombre creado satisfactoriamente"
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Crear usuario BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
