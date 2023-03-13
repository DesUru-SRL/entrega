#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Definir ubicacion de logs"
	echo "2. Mostrar logs"
	echo "3. Vaciar logs"
	echo "4. Mostrar logs del sistema"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	bash administracionLogs/definirUbicacionDeLogs.sh
		;;
		2)
			bash administracionLogs/mostrarLogs.sh
		;;
		3)
			bash administracionLogs/vaciarLogs.sh
		;;
		4)
			sudo bash administracionLogs/mostrarLogsDelSistema.sh
		;;
		0)
			echo "T-T"
		;;
	esac
done
