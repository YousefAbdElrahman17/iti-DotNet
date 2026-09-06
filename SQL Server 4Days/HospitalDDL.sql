-- Hospital.dbo.Consultant definition

-- Drop table

-- DROP TABLE Hospital.dbo.Consultant;

CREATE TABLE Hospital.dbo.Consultant (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Consulta__3214EC27896E742B PRIMARY KEY (ID)
);


-- Hospital.dbo.Drug definition

-- Drop table

-- DROP TABLE Hospital.dbo.Drug;

CREATE TABLE Hospital.dbo.Drug (
	Code int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Brand varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Dosage varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Drug__A25C5AA6F218F454 PRIMARY KEY (Code)
);


-- Hospital.dbo.Ward definition

-- Drop table

-- DROP TABLE Hospital.dbo.Ward;

CREATE TABLE Hospital.dbo.Ward (
	ID int NOT NULL,
	Name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Ward__3214EC27F15EFD8E PRIMARY KEY (ID)
);


-- Hospital.dbo.Nurse definition

-- Drop table

-- DROP TABLE Hospital.dbo.Nurse;

CREATE TABLE Hospital.dbo.Nurse (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DOB date NULL,
	WardID int NULL,
	SupervisorID int NULL,
	CONSTRAINT PK__Nurse__3214EC2758260F7D PRIMARY KEY (ID),
	CONSTRAINT FK__Nurse__Superviso__3E52440B FOREIGN KEY (SupervisorID) REFERENCES Hospital.dbo.Nurse(ID),
	CONSTRAINT FK__Nurse__WardID__3D5E1FD2 FOREIGN KEY (WardID) REFERENCES Hospital.dbo.Ward(ID)
);


-- Hospital.dbo.Patient definition

-- Drop table

-- DROP TABLE Hospital.dbo.Patient;

CREATE TABLE Hospital.dbo.Patient (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	WardID int NULL,
	ConsultantID int NULL,
	CONSTRAINT PK__Patient__3214EC278CEF4341 PRIMARY KEY (ID),
	CONSTRAINT FK__Patient__Consult__4222D4EF FOREIGN KEY (ConsultantID) REFERENCES Hospital.dbo.Consultant(ID),
	CONSTRAINT FK__Patient__WardID__412EB0B6 FOREIGN KEY (WardID) REFERENCES Hospital.dbo.Ward(ID)
);


-- Hospital.dbo.Examines definition

-- Drop table

-- DROP TABLE Hospital.dbo.Examines;

CREATE TABLE Hospital.dbo.Examines (
	ConsultantID int NOT NULL,
	PatientID int NOT NULL,
	ExamDate date NOT NULL,
	CONSTRAINT PK__Examines__5B6CEFC5D94DD812 PRIMARY KEY (ConsultantID,PatientID,ExamDate),
	CONSTRAINT FK__Examines__Consul__49C3F6B7 FOREIGN KEY (ConsultantID) REFERENCES Hospital.dbo.Consultant(ID),
	CONSTRAINT FK__Examines__Patien__4AB81AF0 FOREIGN KEY (PatientID) REFERENCES Hospital.dbo.Patient(ID)
);


-- Hospital.dbo.Gives definition

-- Drop table

-- DROP TABLE Hospital.dbo.Gives;

CREATE TABLE Hospital.dbo.Gives (
	NurseID int NOT NULL,
	PatientID int NOT NULL,
	DrugCode int NOT NULL,
	Dosage varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	GiveTime time NOT NULL,
	GiveDate date NOT NULL,
	CONSTRAINT PK__Gives__1171D98E82BCD435 PRIMARY KEY (NurseID,PatientID,DrugCode,GiveDate,GiveTime),
	CONSTRAINT FK__Gives__DrugCode__46E78A0C FOREIGN KEY (DrugCode) REFERENCES Hospital.dbo.Drug(Code),
	CONSTRAINT FK__Gives__NurseID__44FF419A FOREIGN KEY (NurseID) REFERENCES Hospital.dbo.Nurse(ID),
	CONSTRAINT FK__Gives__PatientID__45F365D3 FOREIGN KEY (PatientID) REFERENCES Hospital.dbo.Patient(ID)
);