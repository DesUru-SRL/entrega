#!/bin/bash

read -p "Ingrese la nueva direccion del directorio de respaldo (ruta absoluta): " direccion
echo "`cat configuracion/direccionUbuntu.conf`:$direccion" > "configuracion/directorioDeRespaldoConfiguracion.conf"
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Editar directorio de respaldo (configuraciones)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Editar directorio de respaldo (configuraciones)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
