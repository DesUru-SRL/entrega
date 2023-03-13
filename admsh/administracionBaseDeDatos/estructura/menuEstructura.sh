#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Eliminar BD"
	echo "2. Vaciar BD"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionBaseDeDatos/estructura/eliminarBD.sh 
		;;
		2)
			sudo bash administracionBaseDeDatos/estructura/vaciarBD.sh
		;;
		0)
			echo "o.o"
		;;
	esac
done
