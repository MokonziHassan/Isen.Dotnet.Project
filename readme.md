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
créer projet console : `dotnet new console`
exécuter le projet console : `dotnet run`

##Commit Git : 
Depuis la racine du  projet
Etat des fichiers (non trackés) : `git status`
Tracker les fichiers : `git add .`
Commit : `git commit -m "Initial comment"`
update commit : `git commit -a -m "updating readme"`

##Création d'un projet librairie
mkdir Isen.Dotnet.Library
cd Isen.Dotnet.Library
dotnet new classlib

#Ajout  de la librairoe en reference du projet console
Depuis le dossier du projet console
dotnet add reference 
coder la classe Hello
Dans le program.cs, ajouter le using et appeler la classe greeting

#Création d'une solution et ajout des projets
Depuis le dossier racine
créer le fichier solution : `dotnet new sln`
Ajouter le projet librairie : `dotnet sln add Isen.Dotnet.Library\Isen.Dotnet.Library.csproj`
Ajouter le projet console: `dotnet sln add Isen.Dotnet.ConsoleApp\Isen.Dotnet.ConsoleApp.csproj`

#Commit Git :
`git add .`
`git commit -m "Console, lib, solution"`

##Ajout d'un projet de test
TDD = Test Driven Development
Depuis le dossier racine :
mkdir Isen.Dotnet.Tests
cd Isen.Dotnet.Tests
`dotnet new xunit`

##Ajouter le projet à la solution (depuis le dossier racine)
dotnet sln add Isen.Dotnet.Tests\Isen.Dotnet.Tests.csproj
##Ajouter le dossier du projet de tests : 
Ajouter le projet librairie : `dotnet add  reference Isen.Dotnet.Library\Isen.Dotnet.Library.csproj`

##Commit git
`git add`
`git commit -m  "Test Project"`

##Push du projet sur un repos remote

Créer un projet sur le serveur git de votre choix ( GitHub, GitLab, interne ISEN ...)
l'url de mon repo : 
git remote add origin https://github.com/MokonziHassan/Isen.Dotnet.Project.git
git push -u origin master

##Ajout d'un tag Git
Créer le tag dans le repo local
git tag v0.1
Push le tag dans le remote repo
git push origin v0.1

##Ajout d'un modèle
#Types personnes et city
* Dans le projet Library :
* Créer un dossier Models/Implementation
* Créer une classe Person :
  * `Id`(int)
  * `Name`(string)
  * `FirstName` (string)
  * `LastName` (string)
  * `BirthDate` (DateTime)
* Créer une classe City
  * `Id` (int)
  * `Name`(string)

##Refactoring : extraction d'un MaseModel
Les classes person et city ont une partie de leur logique commune
Extraire ce qui est commun dans une classse abstraite `BaseModel`
La classe de base sers dans le dossier Models/Base

#Ajout de repositories
##CityRepositories
A la racine de Library créer un dossier repository Repositories/InMemory
Ajouter une classe InMemoryCityRepository

##Refactoring interface : extraire IBaseRepository
Déplacer les 3 méthodes 