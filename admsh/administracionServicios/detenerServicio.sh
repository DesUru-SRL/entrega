#!/bin/bash
echo "
Seleccione el servicio:
1. ssh
2. syslog
3. network-manager
4. rsync
5. cron
"
read $ops
	case $ops in
		1)
		 	sudo systemctl stop ssh
		;;
		2)
			sudo systemctl stop syslog
		;;
		3)
			sudo systemctl stop network-manager
		;;
		4)
			sudo systemctl stop rsync
		;;
		5)
			sudo systemctl stop cron
        	;;
        	*)
            		echo "Opcion incorrecta."
			aaaaaaaaaaaaaaaaaaaaaaaa
			clear
        	;;
	esac
if [ "$?" != "0" ];then
	echo "Se ha producido un error."
	read -p "Aplaste ENTER para volver."
	echo "[X] `date +'%F %T'`: Detener servicio" >> "`cat configuracion/ubicacionLog.conf`/audit.log"	
else
	echo "[O] `date +'%F %T'`: Detener servicio" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi

