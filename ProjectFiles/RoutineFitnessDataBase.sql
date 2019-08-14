-------------------------------------
-- Script that creates a the database RoutineFitness
--This database will be used to store user accounts, workout for the users to choose from
--and saves the routines that are created and shared
-------------------------------------
--This Database will be used for my class project for creating a webapplication that allows
--users to create, save, and share weight lifting routines
-------------------------------------

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
	

-- This is a test it works
--SELECT r.created, u.username
--FROM Routines AS r
--JOIN Users AS u ON r.userid = u.userid
--WHERE u.userid = 1;