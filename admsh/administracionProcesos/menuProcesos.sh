#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Ver procesos"
	echo "2. Pausar proceso"
	echo "3. Continuar proceso"
	echo "4. Eliminar proceso"
	echo "5. Terminar proceso"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionProcesos/verProcesos.sh 
		;;
		2)
			sudo bash administracionProcesos/pausarProceso.sh
		;;
		3) 
			sudo bash administracionProcesos/continuarProceso.sh 
		;;
		4)
			sudo bash administracionProcesos/eliminarProceso.sh
		;;
		5)
			sudo bash administracionProcesos/terminarProceso.sh
		;;
		0)
			echo "B)"
		;;
	esac
done
