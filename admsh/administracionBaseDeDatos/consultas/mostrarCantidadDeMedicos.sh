#!/bin/bash
echo "select count(*) from medico" > comando.sql
dbaccess desuru@demo_on omando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Mostrar cantidad de medicos" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Mostrar cantidad de medicos" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
rm comando.sql
