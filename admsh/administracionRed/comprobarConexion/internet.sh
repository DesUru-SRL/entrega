#!/bin/bash
echo "Comprobacion conexion a internet: "
ping -c 4 8.8.4.4
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Comprobar conexion a internet" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."    
    echo "[O] `date +'%F %T'`: Comprobar conexion a internet" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi

