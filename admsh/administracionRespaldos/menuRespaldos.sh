#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Respaldo base de datos"
	echo "2. Respaldo logs"
	echo "3. Respaldo configuraciones"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionRespaldos/respaldoBaseDeDatos/menuRespaldoBaseDeDatos.sh 
		;;
		2)
			sudo bash administracionRespaldos/respaldoLogs/menuRespaldoLogs.sh
		;;
		3)
			sudo bash administracionRespaldos/respaldoConfiguraciones/menuRespaldoConfiguraciones.sh
		;;
		0)
			echo "u.u"
		;;
	esac
done
