#!/bin/bash
read -p "Ingrese nombre de grupo: " grupo
sudo groupadd $grupo
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Crear grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Crear grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi

