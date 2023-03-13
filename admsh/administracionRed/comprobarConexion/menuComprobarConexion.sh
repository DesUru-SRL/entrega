#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Internet"
	echo "2. Servidor de BD"
	echo "3. Servidor de Respaldo"
	echo "4. IP"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	 sudo bash administracionRed/comprobarConexion/internet.sh
		;;
		2)
			 sudo bash administracionRed/comprobarConexion/servidorDeBD.sh
		;;
		3)
			 sudo bash administracionRed/comprobarConexion/servidorDeRespaldo.sh
		;;
		4)
			 sudo bash administracionRed/comprobarConexion/IP.sh
		;;
		0)
			echo ">/////<"
		;;
	esac
done
