#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Crear usuario"
	echo "2. Crear grupo"
	echo "3. Modificar nombre de usuario"
	echo "4. Modificar nombre de grupo"
	echo "5. Modificar contrasena de usuario"
	echo "6. Agregar usuario a grupo"
	echo "7. Agregar usuario al grupo sudo"
	echo "8. Quitar usuario de grupo"
	echo "9. Eliminar usuario"
	echo "10. Eliminar grupo"
	echo "11. Crear usuarios/grupos predeterminados"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1)
		 	sudo bash administracionUsuariosGrupos/crearUsuario.sh
		;;
		2)
			sudo bash administracionUsuariosGrupos/crearGrupo.sh
		;;
		3)
			sudo bash administracionUsuariosGrupos/modificarNombreDeUsuario.sh
		;;
		4)
			sudo bash administracionUsuariosGrupos/modificarNombreDeGrupo.sh
		;;
		5)
			sudo bash administracionUsuariosGrupos/modificarContrasenaDeUsuario.sh
		;;
		6)
			sudo bash administracionUsuariosGrupos/agregarUsuarioGrupo.sh
		;;
		7)
			sudo bash administracionUsuariosGrupos/agregarUsuarioSudo.sh
		;;
		8)
			sudo bash administracionUsuariosGrupos/quitarUsuarioDeGrupo.sh
		;;
		9)
			sudo bash administracionUsuariosGrupos/eliminarUsuario.sh
		;;
		10)
			sudo bash administracionUsuariosGrupos/eliminarGrupo.sh
		;;
		11)
			sudo bash administracionUsuariosGrupos/crearUsuariosDefault.sh
		;;
		0)
			echo "uwu"
		;;
	esac
done
