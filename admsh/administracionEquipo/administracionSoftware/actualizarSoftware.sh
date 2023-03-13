#!/bin/bash 
read -p "ingrese el nombre de la aplicacion que desea actualizar " app
sudo apt-get update $app
sudo apt-get upgrade $app