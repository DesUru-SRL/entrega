#!/bin/bash

read -p "Ingrese la hora deseada para cambiar (formato: hh:mm) " hora 
sudo date -s "$hora" 