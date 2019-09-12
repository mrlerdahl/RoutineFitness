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
-------------------------------------<br>
-- Script that creates a the database RoutineFitness<br>
--This database will be used to store user accounts, workout for the users to choose from<br>
--and saves the routines that are created and shared<br>
-------------------------------------<br>
--This Database will be used for my class project for creating a webapplication that allows<br>
--users to create, save, and share weight lifting routines<br>
-------------------------------------<br>

DROP Database IF EXISTS RoutineFitness;
CREATE Database RoutineFitness;

USE RoutineFitness;
--Creates a table of user accounts
DROP TABLE IF EXISTS Users;
CREATE TABLE Users
(
	userid    INT           NOT NULL IDENTITY,
	username  NVARCHAR(25)  NOT NULL,
	password  NVARCHAR(40)  NOT NULL,
	firstname NVARCHAR(25)  NULL,
	lastname  NVARCHAR(30)  NULL,
	CONSTRAINT PK_Users PRIMARY KEY(userid) 
);
-- I need to add a savedRoutine column, but I want it to hold a file of saved routines


-- Creates a table that holds all the different lifts
DROP TABLE IF EXISTS MuscleGroups;
CREATE TABLE MuscleGroups
(
	musclegroupid INT          NOT NULL IDENTITY,
	legs          NVARCHAR(20) NULL,
	calves        NVARCHAR(20) NULL,
	abdominals    NVARCHAR(20) NULL,
	chest         NVARCHAR(20) NULL,
	triceps       NVARCHAR(20) NULL,
	biceps        NVARCHAR(20) NULL,
	back          NVARCHAR(20) NULL,
	shoulders     NVARCHAr(20) NULL,
	allmuscles    NVARCHAR(20) NULL,
	CONSTRAINT PK_MuscleGroups PRIMARY KEY(musclegroupid)
);

-- Creates a table of Routines
DROP TABLE IF EXISTS Routines;
CREATE TABLE Routines
(
	routineid INT          NOT NULL IDENTITY,
	userid    INT          NOT NULL,
	shared    NVARCHAR(50) NULL,
	created   NVARCHAR(50) NULL,
	CONSTRAINT PK_Routines PRIMARY KEY(routineid),
	CONSTRAINT FK_Routines_Users FOREIGN KEY(userid)
		REFERENCES Users(userid)
);

-- Populates the Users table
SET IDENTITY_INSERT users ON;
INSERT INTO Users (userid, username, password, firstname, lastname)
	VALUES
		(1, 'mrlerdahl', 'password1', 'Mitchell', 'Lerdahl'),
		(2, 'Taco', 'password2', 'Tony', 'Lark'),
		(3, 'BuffDude', 'password3', 'Bob', 'Stiller'),
		(4, 'BuffChick', 'password4', 'Sandy', 'Beach'),
		(5, 'GirlLifter', 'password5', 'Holly', 'Wood')
SET IDENTITY_INSERT users OFF;

-- Populates the Muscle Groups table
SET IDENTITY_INSERT musclegroups ON;
INSERT INTO MuscleGroups (musclegroupid, legs, calves, abdominals, chest, triceps, biceps, back, shoulders, allmuscles)
	VALUES
		(1, 'Back Squat', 'Standing Calf Raises', 'Cable Crunch', 'Bench Press', 'Tricep Extension', 'Hammer Curls', 'Bent Over Rows', 'Shoulder DB Press', NULL),
		(2, 'Back Squat', 'Standing Calf Raises', 'Cable Crunch', 'Bench Press', 'Tricep Extension', 'Hammer Curls', 'Bent Over Rows', 'Shoulder DB Press', NUll),
		(3, 'Back Squat', 'Standing Calf Raises', 'Cable Crunch', 'Bench Press', 'Tricep Extension', 'Hammer Curls', 'Bent Over Rows', 'Shoulder DB Press', NULL),
		(4, 'Back Squat', 'Standing Calf Raises', 'Cable Crunch', 'Bench Press', 'Tricep Extension', 'Hammer Curls', 'Bent Over Rows', 'Shoulder DB Press', NULL),
		(5, 'Back Squat', 'Standing Calf Raises', 'Cable Crunch', 'Bench Press', 'Tricep Extension', 'Hammer Curls', 'Bent Over Rows', 'Shoulder DB Press', NULL)
SET IDENTITY_INSERT musclegroups OFF;


-- Populates the Routines table
SET IDENTITY_INSERT Routines ON;
INSERT INTO Routines (routineid, userid, shared, created)
	VALUES
		(1, 1, 'My First Routine', 'My First Routine'),
		(2, 2, 'Create Taco Bump Arms', 'Create Taco Bump Arms'),
		(3, 4, 'Beach Bod', 'Beach Bod'),
		(4, 1, NULL , 'My Second Routine'),
		(5, 3, 'Bobby Boulder Shoulders', 'Bobby Boulder Shoulders')
SET IDENTITY_INSERT Routines OFF;
</code></pre>

## Entity Relationship Diagram
![alt text](/ProjectFiles/ERD2.jpg)
As mentioned in the description there will no longer be a user profile or a journal, this feature will be added once the main concept is completed.

## UML Diagram
![alt text](/ProjectFiles/UML.jpg)

## Testing and RTM
![alt text](/ProjectFiles/TestsRTM.JPG)


## Prototype
http://routinefitness.atwebpages.com <br>
This will look enlarged for a website, the designed is meant to look good on a mobile device.
