#!/bin/bash
echo "Comprobar conexion a servidor BD"
direccion=`cat configuracion/direccionServidorecho "Comprobar conexion a servidor BD"
direccion=`cat configuracion/direccionBD.conf`
ping -c 4 $direccionBD.conf`
ping -c 4 $direccion
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Comprobar conexion a servidor BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Comprobar conexion a servidor BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
