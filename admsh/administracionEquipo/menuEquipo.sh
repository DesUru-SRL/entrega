#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Reiniciar"
	echo "2. Apagar"
	echo "3. Fecha y hora"
	echo "4. Administracion de software"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	sudo bash administracionEquipo/reiniciar.sh
		;;
		2)
			sudo bash administracionEquipo/apagar.sh
		;;
		3)
			sudo bash administracionEquipo/fechaHora/menuFechaHora.sh
		;;
		4)
			sudo bash administracionEquipo/administracionSoftware/menuSoftware.sh
		;;
		0)
			echo "T-T"
		;;
	esac
done
