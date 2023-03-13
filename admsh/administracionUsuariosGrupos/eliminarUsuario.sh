#!/bin/bash
read -p "Ingrese nombre de usuario: " nombre
sudo userdel -r $nombre
if [ "$?" != "0" ]; then
    echo "Se ha producido un error."
    read -p "Aplaste ENTER para volver."
    echo "[X] `date +'%F %T'`: Eliminar usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
else
    echo "[O] `date +'%F %T'`: Eliminar usuario" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
