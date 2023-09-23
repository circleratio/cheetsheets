#!/usr/bin/bash

MD_FOLDER=${HOME}/work/cs/sheets
MD2HTML="python3 ${HOME}/tmp/md2x/md2x.py"
FILE="$MD_FOLDER"/"$1".md

if [ ! -f "$FILE" ]; then
    echo No cheet sheet for "$1".
    exit
fi

cat "$FILE" | ${MD2HTML} | w3m -T text/html
