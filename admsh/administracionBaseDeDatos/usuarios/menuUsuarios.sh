#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Crear usuario"
	echo "2. Eliminar usuario"
	echo "3. Cambiar constrasena"
	echo "4. Mostrar usuarios"
	echo "5. Permitir acceso"
	echo "6. Revocar acceso"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			bash administracionBaseDeDatos/usuarios/crearUsuario.sh 
		;;
		2)
			bash administracionBaseDeDatos/usuarios/eliminarUsuario.sh
		;;
		3) 
			bash administracionBaseDeDatos/usuarios/cambiarContrasena.sh 
		;;
		4) 
			bash administracionBaseDeDatos/usuarios/mostrarUsuarios.sh 
		;;
		5) 
			bash administracionBaseDeDatos/usuarios/permitirAcceso.sh 
		;;
		6) 
			bash administracionBaseDeDatos/usuarios/revocarAcceso.sh 
		;;
		0)
			echo "unu"
		;;
	esac
done
