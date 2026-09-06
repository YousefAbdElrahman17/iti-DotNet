-- MusicSystem.dbo.Instrument definition

-- Drop table

-- DROP TABLE MusicSystem.dbo.Instrument;

CREATE TABLE MusicSystem.dbo.Instrument (
	Name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	InstKey varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Instrume__737584F7BB21B584 PRIMARY KEY (Name)
);


-- MusicSystem.dbo.Musician definition

-- Drop table

-- DROP TABLE MusicSystem.dbo.Musician;

CREATE TABLE MusicSystem.dbo.Musician (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Street varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	City varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Phone varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Musician__3214EC27134C2E73 PRIMARY KEY (ID)
);


-- MusicSystem.dbo.Album definition

-- Drop table

-- DROP TABLE MusicSystem.dbo.Album;

CREATE TABLE MusicSystem.dbo.Album (
	ID int NOT NULL,
	Title varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CrDate date NULL,
	MusicianID int NULL,
	CONSTRAINT PK__Album__3214EC2751F152F2 PRIMARY KEY (ID),
	CONSTRAINT FK__Album__MusicianI__3F466844 FOREIGN KEY (MusicianID) REFERENCES MusicSystem.dbo.Musician(ID)
);


-- MusicSystem.dbo.Plays definition

-- Drop table

-- DROP TABLE MusicSystem.dbo.Plays;

CREATE TABLE MusicSystem.dbo.Plays (
	MusicianID int NOT NULL,
	InstrumentName varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK__Plays__47EA8737A705AD2C PRIMARY KEY (MusicianID,InstrumentName),
	CONSTRAINT FK__Plays__Instrumen__3C69FB99 FOREIGN KEY (InstrumentName) REFERENCES MusicSystem.dbo.Instrument(Name),
	CONSTRAINT FK__Plays__MusicianI__3B75D760 FOREIGN KEY (MusicianID) REFERENCES MusicSystem.dbo.Musician(ID)
);


-- MusicSystem.dbo.Song definition

-- Drop table

-- DROP TABLE MusicSystem.dbo.Song;

CREATE TABLE MusicSystem.dbo.Song (
	ID int NOT NULL,
	Title varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Author varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	AlbumID int NULL,
	CONSTRAINT PK__Song__3214EC27E837B2A2 PRIMARY KEY (ID),
	CONSTRAINT FK__Song__AlbumID__4222D4EF FOREIGN KEY (AlbumID) REFERENCES MusicSystem.dbo.Album(ID)
);