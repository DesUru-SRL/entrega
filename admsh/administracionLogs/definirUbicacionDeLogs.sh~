#!/bin/bash
read -p "Ingrese ubicacion: " direccion
direccionActual=`cat configuracion/ubicacionLog.conf`
mkdir -p "$direccion"
mv "$direccionActual/audit.log" "$direccion/audit.log"
rmdir "$direccionActual"
echo $direccion > configuracion/ubicacionLog.conf
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Definir ubicacion de los logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Definir ubicacion de los logs" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi

