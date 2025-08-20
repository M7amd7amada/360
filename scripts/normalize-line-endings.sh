#!/bin/bash

echo "Normalizing line endings for .NET project..."

# Convert all C# files to Unix line endings
find . -name "*.cs" -type f -exec dos2unix {} \;

# Ensure single newline at end of files
find . -name "*.cs" -type f -exec sed -i -e '$a\' {} \;

# Remove empty lines at end
find . -name "*.cs" -type f -exec sed -i '/^$/d' {} \;

echo "Line endings normalized successfully!"
echo "All .cs files now have Unix line endings (LF) and single newline at end."
