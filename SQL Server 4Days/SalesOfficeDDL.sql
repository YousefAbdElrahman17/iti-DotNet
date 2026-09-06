-- SalesOffice.dbo.Owner definition

-- Drop table

-- DROP TABLE SalesOffice.dbo.Owner;

CREATE TABLE SalesOffice.dbo.Owner (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Owner__3214EC27405CC9ED PRIMARY KEY (ID)
);


-- SalesOffice.dbo.Sales_Office definition

-- Drop table

-- DROP TABLE SalesOffice.dbo.Sales_Office;

CREATE TABLE SalesOffice.dbo.Sales_Office (
	Num int NOT NULL,
	City varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	State varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Zip varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Sales_Of__C7D08B63F69E1723 PRIMARY KEY (Num)
);


-- SalesOffice.dbo.Employee definition

-- Drop table

-- DROP TABLE SalesOffice.dbo.Employee;

CREATE TABLE SalesOffice.dbo.Employee (
	ID int NOT NULL,
	Name varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	OfficeNum int NULL,
	CONSTRAINT PK__Employee__3214EC27EF1473D9 PRIMARY KEY (ID),
	CONSTRAINT FK__Employee__Office__3B75D760 FOREIGN KEY (OfficeNum) REFERENCES SalesOffice.dbo.Sales_Office(Num)
);


-- SalesOffice.dbo.Property definition

-- Drop table

-- DROP TABLE SalesOffice.dbo.Property;

CREATE TABLE SalesOffice.dbo.Property (
	ID int NOT NULL,
	Loc varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	OfficeNum int NULL,
	EmployeeID int NULL,
	CONSTRAINT PK__Property__3214EC278DEF4DCF PRIMARY KEY (ID),
	CONSTRAINT FK__Property__Employ__3F466844 FOREIGN KEY (EmployeeID) REFERENCES SalesOffice.dbo.Employee(ID),
	CONSTRAINT FK__Property__Office__3E52440B FOREIGN KEY (OfficeNum) REFERENCES SalesOffice.dbo.Sales_Office(Num)
);


-- SalesOffice.dbo.Has_Property definition

-- Drop table

-- DROP TABLE SalesOffice.dbo.Has_Property;

CREATE TABLE SalesOffice.dbo.Has_Property (
	OwnerID int NOT NULL,
	PropertyID int NOT NULL,
	PercentOwned decimal(5,2) NULL,
	CONSTRAINT PK__Has_Prop__C69F1FED49BDF706 PRIMARY KEY (OwnerID,PropertyID),
	CONSTRAINT FK__Has_Prope__Owner__4222D4EF FOREIGN KEY (OwnerID) REFERENCES SalesOffice.dbo.Owner(ID),
	CONSTRAINT FK__Has_Prope__Prope__4316F928 FOREIGN KEY (PropertyID) REFERENCES SalesOffice.dbo.Property(ID)
);