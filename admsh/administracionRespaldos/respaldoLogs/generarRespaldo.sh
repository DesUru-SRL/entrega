#!/bin/bash 

direccion=`cat configuracion/directorioDeRespaldoLogs.conf`
rsync -r "`cat configuracion/ubicacionLog.conf`" "$direccion"
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Generar respaldo (logs)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "Respaldo generado satisfactoriamente."
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Generar respaldo (logs)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
