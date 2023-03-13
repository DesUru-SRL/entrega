#!/bin/bash 
read -p "nombre del programa que desea desinstalar " app
sudo apt-get update
sudo apt-get --purge remove $app