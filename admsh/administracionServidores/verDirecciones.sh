touch direccionInformix.txt
touch direccionUbuntu.txt
echo "Direccion del servidor de BD:"
cat direccionInformix.txt
echo "Direccion del servidor de respaldo:"
cat direccionUbuntu.txt
read -p "Aplaste ENTER para volver."
echo "[O] `date +'%F %T'`: Ver direcciones de servidores" >> "`cat configuracion/ubicacionLog.conf`/audit.log""
