#!/bin/bash 
read -p "ingrese el nombre de la aplicacion que desea reinstalar " app
sudo apt-get update
sudo apt-get --purge remove $app
sudo apt-get install $app