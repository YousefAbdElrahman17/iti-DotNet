-- Airline.dbo.Airline definition

-- Drop table

-- DROP TABLE Airline.dbo.Airline;

CREATE TABLE Airline.dbo.Airline (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Address varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ContactPerson varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Airline__3214EC279FE0363C PRIMARY KEY (ID)
);


-- Airline.dbo.Route definition

-- Drop table

-- DROP TABLE Airline.dbo.Route;

CREATE TABLE Airline.dbo.Route (
	ID int NOT NULL,
	Origin varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Destination varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Classification varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Distance int NULL,
	CONSTRAINT PK__Route__3214EC27732A8E04 PRIMARY KEY (ID)
);


-- Airline.dbo.Aircraft definition

-- Drop table

-- DROP TABLE Airline.dbo.Aircraft;

CREATE TABLE Airline.dbo.Aircraft (
	ID int NOT NULL,
	Capacity int NULL,
	Mode varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	AirlineID int NULL,
	CONSTRAINT PK__Aircraft__3214EC277C057F1E PRIMARY KEY (ID),
	CONSTRAINT FK__Aircraft__Airlin__49C3F6B7 FOREIGN KEY (AirlineID) REFERENCES Airline.dbo.Airline(ID)
);


-- Airline.dbo.Airline_Phone definition

-- Drop table

-- DROP TABLE Airline.dbo.Airline_Phone;

CREATE TABLE Airline.dbo.Airline_Phone (
	AirlineID int NULL,
	Phone varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT FK__Airline_P__Airli__3F466844 FOREIGN KEY (AirlineID) REFERENCES Airline.dbo.Airline(ID)
);


-- Airline.dbo.Assigned definition

-- Drop table

-- DROP TABLE Airline.dbo.Assigned;

CREATE TABLE Airline.dbo.Assigned (
	AircraftID int NOT NULL,
	RouteID int NOT NULL,
	DeptDateTime datetime NOT NULL,
	ArrDateTime datetime NULL,
	PassengerNum int NULL,
	CONSTRAINT PK__Assigned__B8AE88A16306701B PRIMARY KEY (AircraftID,RouteID,DeptDateTime),
	CONSTRAINT FK__Assigned__Aircra__5441852A FOREIGN KEY (AircraftID) REFERENCES Airline.dbo.Aircraft(ID),
	CONSTRAINT FK__Assigned__RouteI__5535A963 FOREIGN KEY (RouteID) REFERENCES Airline.dbo.Route(ID)
);


-- Airline.dbo.Crew definition

-- Drop table

-- DROP TABLE Airline.dbo.Crew;

CREATE TABLE Airline.dbo.Crew (
	CrewID int NOT NULL,
	MainPilot varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	AssPilot varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FirstHostess varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	AircraftID int NULL,
	CONSTRAINT PK__Crew__89BCFC09EB76C6E6 PRIMARY KEY (CrewID),
	CONSTRAINT UQ__Crew__F75CBC0AE54267D1 UNIQUE (AircraftID),
	CONSTRAINT FK__Crew__AircraftID__4D94879B FOREIGN KEY (AircraftID) REFERENCES Airline.dbo.Aircraft(ID)
);


-- Airline.dbo.Crew_Hostess definition

-- Drop table

-- DROP TABLE Airline.dbo.Crew_Hostess;

CREATE TABLE Airline.dbo.Crew_Hostess (
	CrewID int NULL,
	HostessName varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT FK__Crew_Host__CrewI__4F7CD00D FOREIGN KEY (CrewID) REFERENCES Airline.dbo.Crew(CrewID)
);


-- Airline.dbo.Employee definition

-- Drop table

-- DROP TABLE Airline.dbo.Employee;

CREATE TABLE Airline.dbo.Employee (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Address varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	BDay int NULL,
	BMonth int NULL,
	BYear int NULL,
	[Position] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Gender char(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	AirlineID int NULL,
	CONSTRAINT PK__Employee__3214EC2719C05D24 PRIMARY KEY (ID),
	CONSTRAINT FK__Employee__Airlin__4222D4EF FOREIGN KEY (AirlineID) REFERENCES Airline.dbo.Airline(ID)
);


-- Airline.dbo.Employee_Qualification definition

-- Drop table

-- DROP TABLE Airline.dbo.Employee_Qualification;

CREATE TABLE Airline.dbo.Employee_Qualification (
	EmployeeID int NULL,
	Qualification varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT FK__Employee___Emplo__440B1D61 FOREIGN KEY (EmployeeID) REFERENCES Airline.dbo.Employee(ID)
);


-- Airline.dbo.Transactions definition

-- Drop table

-- DROP TABLE Airline.dbo.Transactions;

CREATE TABLE Airline.dbo.Transactions (
	ID int NOT NULL,
	Descr varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TransDate date NULL,
	Amount decimal(10,2) NULL,
	AirlineID int NULL,
	CONSTRAINT PK__Transact__3214EC271DB866A3 PRIMARY KEY (ID),
	CONSTRAINT FK__Transacti__Airli__46E78A0C FOREIGN KEY (AirlineID) REFERENCES Airline.dbo.Airline(ID)
);