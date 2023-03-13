#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Generar respaldo"
	echo "2. Editar directorio de respaldo"
	echo "3. Programar respaldo"
	echo "4. Ver política de respaldo"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionRespaldos/respaldoLogs/generarRespaldo.sh 
		;;
		2)
			sudo bash administracionRespaldos/respaldoLogs/editarDirectorioDeRespaldo.sh
		;;
		3)
			sudo bash administracionRespaldos/respaldoLogs/programarRespaldo.sh
		;;
		4)
			sudo bash administracionRespaldos/respaldoLogs/verPoliticaDeRespaldo.sh
		;;
		0)
		;;
	esac
done
