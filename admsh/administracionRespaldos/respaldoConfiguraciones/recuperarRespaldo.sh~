#!/bin/bash 

direccion=`cat configuracion/directorioDeRespaldoConfiguracion.conf`
rsync "$direccion" respaldoConfiguracion
mv configuracion configuracion.old
mv respaldoConfiguracion configuracion
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Recuperar respaldo (configuraciones)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "Respaldo recuperado satisfactoriamente."
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Recuperar respaldo (configuraciones)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
