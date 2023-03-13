#!/bin/bash
echo "Comprobar conexion a servidor de respaldo"
direccion=`cat configuracion/direccionServidorRespaldo.conf`
ping -c 4 $direccion
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Comprobar conexion a servidor respaldo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Comprobar conexion a servidor respaldo" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
