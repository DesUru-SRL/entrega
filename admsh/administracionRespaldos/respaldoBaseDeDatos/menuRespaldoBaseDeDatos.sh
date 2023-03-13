#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Generar respaldo"
	echo "2. Recuperar respaldo"
	echo "3. Editar directorio de respaldo"
    echo "4. Programar respaldo"
    echo "5. Ver politica de respaldo"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionRespaldos/respaldoBaseDeDatos/generarRespaldo.sh 
		;;
		2)
			sudo bash administracionRespaldos/respaldoBaseDeDatos/recuperarRespaldo.sh
		;;
		3)
			sudo bash administracionRespaldos/respaldoBaseDeDatos/editarDirectorioDeRespaldo.sh
		;;
        4)
			sudo bash administracionRespaldos/respaldoBaseDeDatos/programarRespaldo.sh
		;;
        5)
			sudo bash administracionRespaldos/respaldoBaseDeDatos/verPoliticaDeRespaldo.sh
		;;
		0)
		;;
	esac
done
