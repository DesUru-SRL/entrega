#!/bin/bash
read -p "Ingrese nombre de grupo: " grupo
read -p "Ingrese nuevo nombre: " nuevoNombre
sudo groupmod -n $nuevoNombre $grupo
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Modificar nombre de un grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Modificar nombre de un grupo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi