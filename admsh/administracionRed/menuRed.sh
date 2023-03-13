#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Mostrar configuracion"
	echo "2. Configurar IP"
	echo "3. Comprobar conexion"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	 sudo bash administracionRed/mostrarConfiguracion.sh
		;;
		2)
			 sudo bash administracionRed/configurarIP.sh
		;;
		3)
			 sudo bash administracionRed/comprobarConexion/menuComprobarConexion.sh
		;;
		0)
			echo "owo"
		;;
	esac
done
