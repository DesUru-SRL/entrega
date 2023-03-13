#!/bin/bash

echo "Politica de respaldo: "
echo
cat "administracionRespaldos/respaldoBaseDeDatos/politicaRespaldo.txt"
echo
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Ver politica de respaldo (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Ver politica de respaldos (base de datos)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
