#!/bin/bash 
read -p "ingrese el nombre de la aplicacion que desea instalar " app
sudo apt-get update
sudo apt-get install $app