#!/bin/sh
. "$(dirname "$0")/common.sh"

$SUDO cp $CRTFILE "/usr/local/share/ca-certificates"
$SUDO update-ca-certificates

cleanup