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
cp temp/AdditionalKeys.pdb build/AdditionalKeys.pdb

# Remove temp directory
rm -rf temp

cd build

# zip the contents of the build folder
zip -r "Additional-Keys-0.6.x-1.0.0.zip" *

cd ..