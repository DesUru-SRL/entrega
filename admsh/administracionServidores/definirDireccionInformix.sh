#!/bin/bash

read -p "Ingrese la nueva direccion del servidor de BD: " direccion
echo "$direccion" > configuracion/direccionServidorBD.conf
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Definir direccion servidor de base de datos" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Definir direccion servidor de base de datos" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
