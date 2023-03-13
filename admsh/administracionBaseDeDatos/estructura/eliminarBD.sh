#!/bin/bash
read -p "Ingrese el nombre de la base de datos que desea eliminar " nombre
echo "drop database demo@on$nombre" > administracionBaseDeDatos/comando.sql
dbaccess desuru@demo_on administracionBaseDeDatos/comando.sql
rm comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Eliminar BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Eliminar BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
