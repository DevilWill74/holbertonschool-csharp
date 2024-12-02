#!/bin/bash

# Nom du projet et du dossier
PROJECT_NAME="1-new_project"

# Vérification si le dossier existe déjà
if [ -d "$PROJECT_NAME" ]; then
    echo "Le dossier $PROJECT_NAME existe déjà. Suppression et création d'un nouveau projet."
    rm -rf "$PROJECT_NAME"
fi

# Création du projet console
echo "Création d'un nouveau projet C# dans le dossier $PROJECT_NAME..."
dotnet new console -o "$PROJECT_NAME"

# Construction du projet
echo "Construction du projet..."
cd "$PROJECT_NAME" || exit
dotnet build

echo "Le projet $PROJECT_NAME a été créé et construit avec succès."
