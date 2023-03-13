#!/bin/bash
direccion=`cat configuracion/ubicacionLog.conf`
cat "$direccion/audit.log"
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    echo "[X] `date +'%F %T'`: Mostrar logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Mostrar logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
read -p "Aplaste ENTER para volver."
