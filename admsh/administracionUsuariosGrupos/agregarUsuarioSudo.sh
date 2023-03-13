#!/bin/bash
read -p "Ingrese nombre de usuario: " nombre
sudo usermod -G sudo $nombre
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Agregar usuario a grupo sudo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Agregar usuario a grupo sudo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
