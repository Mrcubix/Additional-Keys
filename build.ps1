# Remove build folder & contents if it exists
if (Test-Path -Path build) {
    Remove-Item -Recurse -Force build/*
}

dotnet publish -c Release -o temp

# create build folder if it doesn't exist
if (!(Test-Path -Path .\build)) {
    New-Item -ItemType Directory -Path .\build
}

# copy AdditionalKeys.dll to build folder
Copy-Item .\temp\AdditionalKeys.dll .\build\AdditionalKeys.dll
Copy-Item .\temp\AdditionalKeys.pdb .\build\AdditionalKeys.pdb

# remove temp folder

Remove-Item -Recurse -Force temp

# zip the contents of the build folder

Compress-Archive -Path .\build\* -DestinationPath .\build\AdditionalKeys.zip