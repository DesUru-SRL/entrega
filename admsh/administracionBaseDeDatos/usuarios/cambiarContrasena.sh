#!/bin/bash
read -p "ingrese el nombre del usuario que desea modificar " nom
read -p "ingrese la nueva contraseña del usuario " contra
echo "ALTER USER $nom MODIFY PASSWORD $contra" > administracionBaseDeDatos/comando.sql
dbaccess desuru@demo_on administracionBaseDeDatos/comando.sql
rm comando.sql
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Cambiar contrasena usuario BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    read -p "Aplaste ENTER para volver."
    echo "[O] `date +'%F %T'`: Cambiar contrasena usuario BD" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
