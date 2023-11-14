#!/bin/bash

# Remove old build files
if [ -d "build" ]; then
    rm -rf build
fi

dotnet publish -c Release -o temp

# Create build directory
if [ ! -d "build" ]; then
    mkdir build
fi

# Copy files to build directory
cp temp/AdditionalKeys.dll build/AdditionalKeys.dll

# Remove temp directory
rm -rf temp