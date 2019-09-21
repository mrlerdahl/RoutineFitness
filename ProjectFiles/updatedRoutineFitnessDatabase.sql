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
	liftid			 INT				NOT NULL IDENTITY,
	category        NVARCHAR(20)	NOT NULL,
	liftname        NVARCHAR(40)	NOT NULL,
	videourl			 NVARCHAR(100) NOT NULL,
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
	 workoutname NVARCHAR(60) NOT NULL,
	 activityid	 INT			  NOT NULL,
	 FOREIGN KEY(userid) REFERENCES Accounts(userid),
	 FOREIGN KEY(activityid) REFERENCES Activity(activityid)
);

