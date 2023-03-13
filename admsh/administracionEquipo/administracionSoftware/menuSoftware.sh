#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Instalar software"
	echo "2. Desinstalar software"
	echo "3. Reinstalar software"
	echo "4. Actualizar software"
	echo "5. Actualizar el sistema"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	sudo bash administracionEquipo/administracionSoftware/instalarSoftware.sh
		;;
		2)
			sudo bash administracionEquipo/administracionSoftware/desinstalarSoftware.sh
		;;
		3)
			sudo bash administracionEquipo/administracionSoftware/reinstalarSoftware.sh
		;;
		4)
			sudo bash administracionEquipo/administracionSoftware/actualizarSoftware.sh
		;;
		5)
			sudo bash administracionEquipo/administracionSoftware/actualizarSistema.sh
		;;
		0)
			echo "x.x"
		;;
	esac
done
