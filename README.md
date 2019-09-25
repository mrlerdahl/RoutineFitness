# RoutineFitness
MSSA class project

## Description
This is a web application that will allow users to have access to a library of various workouts. The users will be able to create weight lifting routines within the application and have the option to share their creation to other users. Users will then be able to search routines made by other users if they don't feel like they have enough knowledge to create their own. Originally this web application was going to have user profile pages and journal pages to keep track of progress and goals, but these features will be implemented later in the project once the main concept is complete.

## Table of Contents
1. [Wire Frame](#Wire-Frame)
2. [Entity Relationship Diagram](#Entity-Relationship-Diagram)
3. [Database](#Database)
4. [UML Diagram](#UML-Diagram)
5. [Testing and RTM](#Testing-and-RTM)
6. [Prototype](#Prototype)

## Wire Frame
![alt text](/ProjectFiles/WireFrame/FrontPage.jpg)
What users will first see when the come to the webpage. Users have the option to continue without and account in order to see what the app is like before creating an account.
![alt text](/ProjectFiles/WireFrame/MuscleGroupsPage.jpg)
Here users will have the option to choose a specific muscles group to see what workouts will target those areas. Each exercise will have a video showing how the exercise is done and a description along with it.
![alt text](/ProjectFiles/WireFrame/SearchRoutinePage.jpg)
Once users start creating routines and sharing the routines they have created other users will then be able to use the search function. Users can type in specific words that will match with other words within titles and the results will appear in the result box. If a blank search is done, then all routines will load.
![alt text](/ProjectFiles/WireFrame/SavedRoutinePage.jpg)
In this section is where the user will be able to find and view the routines they have created and the ones they have saved when searching for routines made by other users.
![alt text](/ProjectFiles/WireFrame/CreateRoutine.jpg)
This page will look a lot like the muscle groups page, but on the right hand side there will be an area where each work out gets created. Also when the users views the work it there will be a button to add that workout to a custome routine
![alt text](/ProjectFiles/WireFrame/CreateRoutineRepsSets.jpg)
Users will be able to set the sets, reps, weight(will be added), and a text box to add any notes for their workout

## Database
<pre><code>
-------------------------------------
-- Script that creates the RoutineFitness database
-- This database will be used to store user accounts, create and search workouts
-------------------------------------

DROP Database IF EXISTS RoutineFitness;
CREATE Database RoutineFitness;

USE RoutineFitness;
-------------------------------------- Create Users Table --------------------------------------
DROP TABLE IF EXISTS Accounts;
CREATE TABLE Accounts
(
	userid    INT           NOT NULL IDENTITY,
	username  NVARCHAR(25)  NOT NULL,
	password  NVARCHAR(40)  NOT NULL,
	firstname NVARCHAR(25)  NULL,
	lastname  NVARCHAR(30)  NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY(userid) 
);

-------------------------------------- Create Lifts Table --------------------------------------
DROP TABLE IF EXISTS Lifts;
CREATE TABLE Lifts
(
	liftid		INT		NOT NULL IDENTITY,
	category        NVARCHAR(20)	NOT NULL,
	liftname        NVARCHAR(40)	NOT NULL,
	videourl	NVARCHAR(100)   NOT NULL,
	liftdescription NVARCHAR(20)	NOT NULL,			  
	CONSTRAINT PK_Lifts PRIMARY KEY(liftid)
);

-------------------------------------- Create Activity Table --------------------------------------
DROP TABLE IF EXISTS Activity;
CREATE TABLE Activity
(
	 activityid int NOT NULL IDENTITY,
	 liftid int NOT NULL,
	 sets int NOT NULL,
	 reps int NOT NULL,
	 weight int NULL
	 CONSTRAINT PK_activityid PRIMARY KEY(activityid),
	 FOREIGN KEY(liftid) REFERENCES Lifts(liftid)
);

-------------------------------------- Create Workouts Table --------------------------------------
DROP TABLE IF EXISTS Workouts;
CREATE TABLE Workouts
(
	 userid		 INT			  NOT NULL,
	 workoutid	 INT			  NOT NULL,
	 workoutname     NVARCHAR(60)             NOT NULL,
	 activityid	 INT			  NOT NULL,
	 FOREIGN KEY(userid) REFERENCES Accounts(userid),
	 FOREIGN KEY(activityid) REFERENCES Activity(activityid)
);
</code></pre>

### Database Diagram
![alt text](/ProjectFiles/RTDatabaseDiagram.JPG)

## Preliminary Entity Relationship Diagram
![alt text](/ProjectFiles/ERD2.jpg)
As mentioned in the description there will no longer be a user profile page nor a journal page, this feature will be added once the main concept is completed.

## UML Diagram
![alt text](/ProjectFiles/UML.jpg)

## Testing and RTM
![alt text](/ProjectFiles/TestsRTM.JPG)


## Prototype
http://routinefitness.atwebpages.com <br>
This is an HTML CSS prototype and will look enlarged for a website, the designed is meant to look good on a mobile device.
