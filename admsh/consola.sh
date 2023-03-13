#!/bin/bash
echo "[INICIO] `date +'%F %T'`: Inicio de Consola" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
echo "Ingrese SALIR para salir de la consola."

while [ "$comando" != "SALIR" ]; do
    read -p "`whoami`@`hostname`:`pwd`> " comando
    if [ "$comando" != "SALIR" ]; then
        bash -c "$comando"
	if [ "$?" != "0" ]; then
	    echo "[X] `date +'%F %T'`: Comando de consola ($comando)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
	else
	    echo "[O] `date +'%F %T'`: Comando de consola ($comando)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
	fi
    fi
done

echo "[FIN] `date +'%F %T'`: Fin de Consola" >> "`cat configuracion/ubicacionLog.conf`/audit.log"

