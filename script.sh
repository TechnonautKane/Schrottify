#!/bin/bash

# This is a simple Bash script

# Define a variable
greeting="Hello, World!"

# Print the variable
echo $greeting

# Use a conditional statement
if [ "$1" == "friendly" ]; then
    echo "Have a great day!"
else
    echo "Goodbye."
fi
