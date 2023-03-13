#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Asignar fecha"
	echo "2. Asignar hora"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	sudo bash administracionEquipo/fechaHora/asignarFecha.sh
		;;
		2)
			sudo bash administracionEquipo/fechaHora/asignarHora.sh
		;;
		0)
			echo "T.T"
		;;
	esac
done
