#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Generar respaldo"
	echo "2. Recuperar respaldo"
	echo "3. Editar directorio de respaldo"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionRespaldos/respaldoConfiguraciones/generarRespaldo.sh 
		;;
		2)
			sudo bash administracionRespaldos/respaldoConfiguraciones/recuperarRespaldo.sh
		;;
		3)
			sudo bash administracionRespaldos/respaldoConfiguraciones/editarDirectorioDeRespaldo.sh
		;;
		0)
		;;
	esac
done
