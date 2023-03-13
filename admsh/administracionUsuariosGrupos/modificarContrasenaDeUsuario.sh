#!/bin/bash
read -p "Ingrese nombre de usuario: " nombre
sudo passwd $nombre
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Modificar contrasena de un usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Modificar contrasena de un usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi