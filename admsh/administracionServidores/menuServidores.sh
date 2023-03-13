#!/bin/bash

ops="The game"
while [ "$ops" != "0" ]; do
	clear
	echo "1. Definir direccion del servidor de BD"
	echo "2. Definir direccion del servidor de respaldo"
	echo "3. Ver direcciones"
    	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			bash administracionServidores/definirDireccionInformix.sh
		;;
		2)
			bash administracionServidores/definirDireccionUbuntu.sh
		;;
		3)
			bash administracionServidores/verDirecciones.sh
		;;
		0)
		;;
	esac
done
