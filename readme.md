# Agenda d'un cabinet de courtiers

>Les exercices sont à faire sur **Visual Studio**, dans une **Application web ASP.NET (.NET Framework)** en utilisant un modèle **Vide** et en ajoutant des **dossiers et des références de base** pour **MVC** afin de respecter une architecture Model-View-Controller.  
*Attention : penser à soigner le style de votre application.*  

## Exercice 1  
Créer le MCD de l'Agenda avec le logiciel **JMerise**.  
Il doit contenir 3 tables.  
1. Table **brokers** contenant les éléments suivants :  

| Colonne     | Type      | Attributs                     |
|-------------|-----------|-------------------------------|
| idBroker    | INT       | Auto-incrémenté, clé primaire |
| lastname    | NVARCHAR  | 50 |
| firstname   | NVARCHAR  | 50 |
| mail        | VARCHAR   | 100 |
| phoneNumber | VARCHAR   | 10 |

2. Table **customers** contenant les éléments suivants :

| Colonne       | Type      | Attributs                     |
| ------------- | --------- | ----------------------------- |
| idCustomer    | INT       | Auto-incrémenté, clé primaire |
| lastname      | NVARCHAR  | 50 |
| firstname     | NVARCHAR  | 50 |
| mail          | VARCHAR   | 100 |
| phoneNumber   | VARCHAR   | 10 |
| budget        | INT       | |

3. Table **appointments** contenant les éléments suivants :  

| Colonne       | Type        | Attributs                     |
| ------------- | ----------- | ----------------------------- |
| idAppointment | INT         | Auto-incrémenté, clé primaire |
| dateHour      | DATETIME    | |
| subject       | TEXT        | |

## Exercice 2  
Créer une base de données **agenda** et y insérer le script SQL Server généré avec le logiciel JMerise à partir de l'exercice précédent.

## Exercice 3  
Faire la maquette de la page index de votre agenda.  
La page index devra contenir :  
  * Une zone avec la date du jour  
  * Une zone permettant d'afficher la liste des rendez-vous

Depuis la page index on pourra se rendre sur les pages :  
  * AddBroker  
  * AddCustomer
  * AddAppointment  
  * ListBrokers  
  * ListCustomers  

## Exercice 4  
Créer un contrôleur MVC vide **HomeController** et une vue **Index** dans le sous-dossier Home du dossier Views.  
Dans le fichier **_Layout.cshtml** généré automatiquement, mettre en place les éléments qui seront communs à toutes vos vues *(par exemple: header, footer...)*.  

Pensez à changer le titre au niveau du bandeau de la fenêtre du navigateur.  

## Exercice 5  
Créer les classes de toutes vos tables dans Visual Studio  en utilisant le **Framework Entity** et le **modèle dans EF Designer** à partir de la base de données.  
Créer ensuite un contrôleur MVC vide par classe.  

## Exercice 6  
Créer une page **AddBroker** *(sans utiliser de modèle pré-généré)* comportant un formulaire permettant à la secrétaire du cabinet de courtiers de créer un nouveau collaborateur.  
Cette page doit être accessible depuis la page **Index**.  

**Bonus :** Afficher les messages d'erreurs si le formulaire n'est pas valide, sinon afficher un message de succès.

## Exercice 7  
Créer une page **ListBrokers** et y afficher la liste des courtiers. La page doit être accessible depuis la page **Index**.  

## Exercice 8  
Créer une page **ProfilBroker** permettant d'afficher toutes les informations d'un courtier.  
Cette page doit être accessible depuis la page **ListBrokers** et elle doit afficher les informations du courtier sélectionné.

## Exercice 9  
Depuis la page **ProfilBroker** permettre la modification de ce courtier.  

## Exercice 10  
Créer une page **AddCustomer** comportant un formulaire permettant à la secrétaire du cabinet de courtiers de créer un nouveau client.  
Cette page doit être accessible depuis la page **Index**.  

## Exercice 11  
Créer une page **ListCustomers** et y afficher la liste des clients par ordre alphabétique à l'aide d'une méthode **SqlQuery**. La page doit être accessible depuis la page **Index**.  

## Exercice 12  
Créer une page **ProfilCustomer** permettant d'afficher toutes les informations d'un client.  
Cette page doit être accessible depuis la page **ListCustomers** et elle doit afficher les informations du client sélectionné.  

## Exercice 13  
Depuis la page **ProfilCustomer** permettre la modification de ce client.  

## Exercice 14  
Depuis la page **ListCustomers** permettre la suppression d'un client.  
*Attention : pensez à demander la confirmation de l'action de suppression*  

## Exercice 15  
Créer une page **AddAppointment** comportant un formulaire permettant à la secrétaire du cabinet de courtiers de créer un rendez-vous pour un des clients enregistrés avec l'un des courtiers du cabinet.
Cette page doit être accessible depuis la page **Index**.  

**Bonus :** ajouter un lien sur la page **ListBrokers** permettant de créer un rendez-vous pour le courtier sélectionné.  
*Attention : un courtier ne peut pas avoir 2 rendez-vous en même temps (même jour et même heure)*

## Exercice 16  
Dans la page **Index** afficher la liste des rendez-vous. Permettre à la secrétaire du cabinet de courtiers d'avoir des informations supplémentaires sur le rendez-vous sélectionné (*nom du client, nom du courtier, objet du rendez-vous notamment*).  

## Exercice 17  
Depuis la page **Index** permettre la suppression d'un rendez-vous.  
*Attention : pensez à demander la confirmation de l'action de suppression*  

## Exercice 18 (bonus)  
Dans la page **ListCustomers** ajouter un champ de recherche permettant à la secrétaire du cabinet de courtiers de retrouver plus rapidement un client.  

## Exercice 19 (bonus)  
Créer une pagination dans la page **ListCustomers**.
