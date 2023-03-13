#!/bin/bash
ubicacion=`cat configuracion/ubicacionLog.conf`
echo "" > "$ubicacion/audit.log"
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Vaciar logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Vaciar logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi

