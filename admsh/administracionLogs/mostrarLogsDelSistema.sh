#!/bin/bash
echo "

boot.log

"
cat /var/log/boot.log | more
echo "

messages

"
cat /var/log/messages | more
echo "

cron

"
cat /var/log/cron | more


read -p "

Aplaste ENTER para volver."
