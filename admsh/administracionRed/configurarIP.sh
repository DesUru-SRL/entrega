#!/bin/bash
read -p "Ingrese la direccion IP: " ipe
read -p "Ingrese la interface: " intrf
ip a add $ipe dev $intrf
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Configurar ip" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Configurar ip" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
