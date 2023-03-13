#!/bin/bash 

dbexport desuru
direccion=`configuracion/directorioDeRespaldoBD.conf`
rsync -r "desuru.exp" "$direccion/desuru.exp"
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Generar respaldo (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "Respaldo generado satisfactoriamente."
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Generar respaldo (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
