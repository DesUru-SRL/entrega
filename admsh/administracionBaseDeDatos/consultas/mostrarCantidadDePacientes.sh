#!/bin/bash
echo "select count(*) from paciente" > comando.sql
dbaccess desuru@demo_on comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Mostrar cantidad de pacientes" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Mostrar cantidad de pacientes" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
rm comando.sql
