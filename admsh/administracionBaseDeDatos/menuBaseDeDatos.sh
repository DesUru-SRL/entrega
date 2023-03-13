#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Usuarios"
	echo "2. Estructura"
	echo "3. Consultas"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			bash administracionBaseDeDatos/usuarios/menuUsuarios.sh 
		;;
		2)
			bash administracionBaseDeDatos/estructura/menuEstructura.sh
		;;
		3) 
			bash administracionBaseDeDatos/consultas/menuConsultas.sh 
		;;
		0)
			echo "ewe"
		;;
	esac
done
