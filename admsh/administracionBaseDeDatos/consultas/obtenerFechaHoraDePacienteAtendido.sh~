#!/bin/bash
echo "select fecha from entrevista order by fecha desc limit 1" > comando.sql
dbaccess desuru@demo_on comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Obtener datos de un paciente" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Obtener datos de un paciente" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
rm comando.sql
