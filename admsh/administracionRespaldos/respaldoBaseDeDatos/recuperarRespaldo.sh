#!/bin/bash 

direccion=`cat configuracion/direccionRespaldo.conf`
rsync "$direccion" "respaldoBaseDeDatos"
dbimport respaldoBaseDeDatos/desuru.exp

if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Recuperar respaldo (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "Respaldo recuperado satisfactoriamente."
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Recuperar respaldo (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
