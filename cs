#!/usr/bin/bash

MD2HTML="python3 ${HOME}/share/md2x/md2x.py"

SCRIPT_DIR=$(dirname $0)
if [[ -L ${SCRIPT_DIR}/cs ]]; then
    SCRIPT_DIR=$(dirname $(readlink -f ${SCRIPT_DIR}/cs))
fi

MD_FOLDER=${SCRIPT_DIR}/sheets

FILE=${MD_FOLDER}/$1.md

if [[ ! -f ${FILE} ]]; then
    echo No cheet sheet for ${1}.
    exit
fi

cat "${FILE}" | ${MD2HTML} | w3m -T text/html
