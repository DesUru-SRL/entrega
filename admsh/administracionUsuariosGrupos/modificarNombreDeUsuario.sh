#!/bin/bash
read -p "Ingrese nombre de usuario: " nombre
read -p "Ingrese nuevo nombre: " nuevoNombre
sudo usermod -l $nuevoNombre $nombre
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Modificar nombre de un usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Modificar nombre de un usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi


