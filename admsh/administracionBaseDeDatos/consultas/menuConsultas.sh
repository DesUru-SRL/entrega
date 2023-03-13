#!/bin/bash

while [ "$ops" != "0" ];
do
	clear
	echo "1. Mostrar cantidad de medicos"
	echo "2. Mostrar cantidad de auxiliares"
	echo "3. Mostrar cantidad de pacientes"
	echo "4. Obtener datos de un paciente dado su documento de identidad"
	echo "5. Obtener la fecha y hora del ultimo paciente atendido"
	echo "0. Volver"
	read ops
	clear
	case $ops in
		1) 
			sudo bash administracionBaseDeDatos/consultas/mostrarCantidadDeMedicos.sh 
		;;
		2)
			sudo bash administracionBaseDeDatos/consultas/mostrarCantidadDeAuxiliares.sh
		;;
		3) 
			sudo bash administracionBaseDeDatos/consultas/mostrarCantidadDePacientes.sh 
		;;
		4) 
			sudo bash administracionBaseDeDatos/consultas/obtenerDatosDePaciente.sh 
		;;
		5) 
			sudo bash administracionBaseDeDatos/consultas/obtenerFechaHoraDePacienteAtendido.sh 
		;;
		0)
			echo "ono"
		;;
	esac
done
