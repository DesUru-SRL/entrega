#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Ver estado de servicio"
	echo "2. Iniciar servicio"
	echo "3. Detener servicio"
	echo "4. Reiniciar servicio"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	sudo bash administracionServicios/verEstadoDeServicio.sh
		;;
		2)
			sudo bash administracionServicios/iniciarServicio.sh
		;;
		3)
			sudo bash administracionServicios/detenerServicio.sh
		;;
		4)
			sudo bash administracionServicios/reiniciarServicio.sh
		;;
		0)
			echo "7u7"
		;;
	esac
done
