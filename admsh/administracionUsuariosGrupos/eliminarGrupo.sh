#!/bin/bash
read -p "Ingrese nombre del grupo: " grupo
sudo groupdel $grupo
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Eliminar grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Eliminar grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi