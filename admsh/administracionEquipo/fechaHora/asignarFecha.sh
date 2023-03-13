#!/bin/bash

read -p "Ingrese la fecha deseada para cambiar (formato: yyyy-MM-dd hh:mm) " hora 
sudo date -s "$hora"