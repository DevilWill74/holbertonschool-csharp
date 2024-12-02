#!/bin/bash

# Create a new directory for the project if it doesn't exist
mkdir -p 2-new_project

# Navigate into the project directory
cd 2-new_project

# Initialize a new C# console application
dotnet new console

# Build the project
dotnet build

# Run the project
dotnet run

# Return to the parent directory
cd ..
