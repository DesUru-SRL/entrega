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
		 	sudo systemctl status ssh
		;;
		2)
			sudo systemctl status syslog
		;;
		3)
			sudo systemctl status network-manager
		;;
		4)
			sudo systemctl status rsync
		;;
		5)
			sudo systemctl status cron
        ;	;
        	*)
            		echo "Opcion incorrecta."
			aaaaaaaaaaaaaaaaaaaaaaaa
			clear
        	;;
	esacif [ "$?" != "0" ];then
	echo "Se ha producido un error."
	read -p "Aplaste ENTER para volver."
	echo "[X] `date +'%F %T'`: Ver estado de un servicio" >> "`cat configuracion/ubicacionLog.conf`/audit.log"	
else
	echo "[O] `date +'%F %T'`: Ver estado de un servicio" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
