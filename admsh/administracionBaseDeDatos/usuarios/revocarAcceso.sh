#!/bin/bash
read -p "ingrese el nombre de usuario que desea quitarle el permiso de conexion " nom
echo "revoke connect from "$nom"" > administracionBaseDeDatos/comando.sql
dbaccess desuru@demo_on administracionBaseDeDatos/comando.sql
rm comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Revocar acceso a la BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Revocar acceso a la BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
