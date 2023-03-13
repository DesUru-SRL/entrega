#!/bin/bash

echo "[INICIO] `date +'%F %T'`: Inicio del Shellscript" >> "`cat configuracion/ubicacionLog.conf`/audit.log"

while [ "$ops" != "0" ]; do
	clear
	echo "1. Administracion de usuarios y grupos"
	echo "2. Administracion de red"
	echo "3. Administracion de servicios"
	echo "4. Administracion de respaldos"
	echo "5. Administracion de base de datos"
	echo "6. Administracion de logs"
	echo "7. Administracion de servidores"
	echo "8. Administracion de equipo"
	echo "9. Administracion de procesos"
	echo "10. Consola"
	echo "0. Salir"
	read ops
	clear
	case $ops in
		1)
			sudo bash administracionUsuariosGrupos/menuUsuariosGrupos.sh
		;;
		2)
			sudo bash administracionRed/menuRed.sh
		;;
		3)
			sudo bash administracionServicios/menuServicios.sh
		;;
		4)
			sudo bash administracionRespaldos/menuRespaldos.sh
		;;
		5) 
			sudo bash administracionBaseDeDatos/menuBaseDeDatos.sh
		;;
		6)
			sudo bash administracionLogs/menuLogs.sh
		;;
		7)
			sudo bash administracionServidores/menuServidores.sh
		;;
		8)
			sudo bash administracionEquipo/menuEquipo.sh
		;;
		9)
			sudo bash administracionProcesos/menuProcesos.sh
		;;
		10)
			sudo bash consola.sh
		;;
		0)
			echo "Fin del Shellscript."
		;;
	esac
done

echo "[FIN] `date +'%F %T'`: Fin del Shellscript" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
echo >> "`cat configuracion/ubicacionLog.conf`/audit.log"