#!/bin/bash

success=0
read -p "Ingrese hora del día [0-23] (Ingrese -1 para todas): " hora
if [ $hora -ge -1 -a $hora -lt 24 ]; then
    if [ $hora -eq -1 ]; then
        hora='*'
    fi
    read -p "Ingrese minuto [0-59] (Ingrese -1 para todos): " minuto
    if [ $minuto -ge -1 -a $minuto -lt 60 ]; then
        if [ $minuto -eq -1 ]; then
            minuto='*'
        fi
        read -p "Ingrese dia del mes [1-31] (Ingrese -1 para todos): " dom
        if [ $dom -ge -1 -a $dom -lt 32 ]; then
            if [ $dom -eq -1 -o $dom -eq 0 ]; then
                dom='*'
            fi
            read -p "Ingrese mes del ano [1-12] (Ingrese -1 para todos): " moy
            if [ $moy -ge -1 -a $moy -lt 13 ]; then
                if [ $moy -eq -1 -o $moy -eq 0 ]; then
                    moy='*'
                fi
                read -p "Ingrese dia de la semana [0-7] (Ingrese -1 para todos): " dow
                if [ $dow -ge -1 -a $dow -lt 8 ]; then
                    if [ $dow -eq -1 ]; then
                        dow='*'
                    fi
                    echo "$minuto $hora $dom $moy $dow administracionRespaldos/respaldoLogs/generarRespaldo.sh" > "administracionRespaldos/respaldoLogs/politicaRespaldo.txt"
                    success=1
                fi
            fi
        fi
    fi
fi

if [ "$success" = "0" ]; then
    echo "[X] `date +'%F %T'`: Programar respaldo (logs)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
    echo "Error. Valor ingresado invalido."
    read -p "Aplaste ENTER para volver."
else
    echo "[O] `date +'%F %T'`: Programar respaldo (logs)" >> "`cat configuracion/ubicacionLog.conf`/audit.log"
fi
