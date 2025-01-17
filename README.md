##Gestion d'event pour ECF ( Event Cool & Fun )✨

## 1.Objectifs du projet

L'objectif de ce projet est de créer une application simple permettant à un administrateur de gérer des événements et leurs participants. 
Les actions principales incluent :
Authentification d'un administrateur pour accéder au système
Gestion des événements : création, modification, suppression, et consultation des détails
Gestion des participants associés à chaque événement : ajout, suppression

## Utilisateurs cibles

Administrateur : Responsable de la gestion complète des événements et participants.

## Technologies
- ASP.NET Core (C#) MVC (Model views controller)
- Bootstrap (pour le design)
Base de données : Entity Framework Core avec SQL Server (admin et événements)
- MongoDB pour stocker les participant 



Fonctionnalités :
- Connexion et Deconnexion en tant qu'admin
- Création, modification, et suppression d'événements
- Affichage des détails d'un événement (y compris la liste des participants)
- Ajout/suppression de participants à des événements 
- Authentification avec AspNetCore.Session

## 2.Description des composants principaux et interactions. 
# 2.1. Composants principaux

# Admin
Propriétés :
Id : Identifiant unique
Name : Nom
Email : Adresse email
Password : Mot de passe

Méthodes :
Auth() : Authentification de l'admin
Create() : Création d'un événement
Delete() : Suppression d'un événement
AddParticipant() : Ajout d'un participant 
RemoveParticipant() : Suppression d'un participant

# Utilisateur (Participant)

Propriétés :
Id : Identifiant unique
Name : Nom
Email : Adresse email

Méthodes :
InscriptionEvent() : Inscription à un événement
DesinscriptionEvent() : Désinscription d’un événement

# Event (Événement)

Propriétés :
Id : Identifiant unique
Name : Nom de l’événement
Date : Date de l’événement
Description : Description de l’événement
Participants : Liste des participants

Méthodes :
Create() : Créer un événement
Delete() : Supprimer un événement
Detail() : Afficher les détails d’un événement

----------------------------------
# 2.2. Interactions entre les composants

Admin et Event : L’administrateur peut créer, modifier, et supprimer des événements.

Admin et Participant : L’administrateur peut ajouter ou retirer des participants d’un événement ou du site.

Participant et Event : Les participants peuvent s’inscrire ou se désinscrire à des événements.

# WorkFlow 
 - Admin se connection -> Accède au tableau de liste d'evenement -> Voir en detail/Ajouter/Modifier/Supprimer un evenement 
	- -> depuis la navbar peut accéder a la liste de participants -> detail/Supprimer
	- -> depuis la navbar peut -> se deconnecter 

-------------------------------
## 3.Diagramme  : 
![ECFDiag](https://github.com/user-attachments/assets/2e7d658d-8c4f-4fa4-bfb2-247806799bba)

---------------------------------

## 4.Instructions d'installation :

Prérequis
.NET SDK (version 6.0 ou ultérieure)
Visual Studio 2022 ou tout autre IDE compatible

1.Cloner le projet
``` git clone https://github.com/Arheee/EventsCoolFun-ECF/ ```
2.Installer les dépendances NuGet nécessaires (EF Core, SQL Server, Tools, Session, MongoDB.Driver)
``` dotnet restore ```
3.Configurer la base de données dans le fichier ``` appsettings.json  ```
4. Exectutez les migrations si base de données activée
 ``` dotnet ef database update  ```
5. Lance l'app avec Visual studio 2022
 ```  dotnet run  ```

# 5.Fonctionnalités
Mise en place des models : Event et Admin en Ef sql server et Participant en MongoDb. SeederMongo pour avoir une liste de participants par défauts. 
Page de connexion : L'admin entre son user et mdp , il est dirigé vers l'acceuil. Accès possible a la liste des events et des participants. 

# 6.Planification future :
Ajouter une gestion des sessions pour sécuriser les actions de l'admin
Développer un CRUD complet pour les participants 
Ajouter des fonctionnalités utilisateur participants (connexion/déconnexion, inscription à des événements, proposition d'évenements)

# 7.Contribution 
Arheee : Justine wlt ✨
_______________________________________________

Ce projet a été réalisé dans le cadre de l'ECF et vise à illustrer les compétences en développement logiciel et gestion de projet.
17/01/2025
