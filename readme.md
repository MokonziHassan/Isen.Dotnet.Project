#Prérequis
Installer visual studio code
Core SDk et runtime

#Préparatifs
mkdir Isen.Dotnet
cd Isen.Dotnet
git init
touch readme.md
code

#Création de l'espace de travail
##Création d'un projet console
mkdir Isen.Dotnet.ConsoleApp
cd Isen.Dotnet.ConsoleApp
dotnet new console
dotnet run

##Commit Git
Depuis la racine du  projet
Etat des fichiers (non trackés) : git status
Tracker les fichiers : git add .
Commit : git commit -m "Initial comment"
git commit -a -m "updating readme'

##Création d'un projet librairie
mkdir Isen.Dotnet.Library
cd Isen.Dotnet.Library
dotnet new classlib

#Ajout  de la librairoe en reference du projet console
Depuis le dossier du projet console
dotnet add reference
