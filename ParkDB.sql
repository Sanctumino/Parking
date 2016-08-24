CREATE TABLE Applications ( 
	ID int identity(1,1)  NOT NULL,
	ApplicationTypeID tinyint,
	ApplicationDate datetime,
	PersonID smallint,
	StatusID tinyint,
	RequestDate date,
	RequestExpiryDate date
)
;

CREATE TABLE ApplicationStatuses ( 
	ID tinyint identity(1,1)  NOT NULL,
	Description nvarchar(20)
)
;

CREATE TABLE ApprovedApplications ( 
	PersonID smallint,
	PlaceID smallint,
	ApprovedApplicationDate datetime,
	ApprovedDateFrom date,
	ApprovedDateTo date
)
;

CREATE TABLE Cars ( 
	ID smallint identity(1,1)  NOT NULL,
	PersonID smallint,
	Make nvarchar(30),
	Model nvarchar(30),
	CarNumber nvarchar(15)
)
;

CREATE TABLE EventLog ( 
	ID int NOT NULL,
	Login nvarchar(50),
	EventText nvarchar(300),
	EventDate datetime
)
;

CREATE TABLE FreePlaces ( 
	PlaceID smallint NOT NULL,
	DateFrom date,
	DateTo date
)
;

CREATE TABLE MessageStatuses ( 
	ID tinyint identity(1,1)  NOT NULL,
	Description nvarchar(20)
)
;

CREATE TABLE Notifications ( 
	PersonID smallint identity(1,1) ,
	Message nvarchar(300),
	SendDate datetime,
	MessageStatusID tinyint
)
;

CREATE TABLE Persons ( 
	ID smallint identity(1,1)  NOT FOR REPLICATION  NOT NULL,
	Lastname nvarchar(50),
	Firstname nvarchar(50),
	PlaceID smallint,
	ReleaseFlag bit,
	LeaveDateFrom date,
	LeaveDateTo date
)
;

CREATE TABLE Places ( 
	ID smallint NOT NULL,
	PersonID smallint,
	StatusID tinyint,
	DateFrom date,
	DateTo date
)
;

CREATE TABLE PlaceStatuses ( 
	ID tinyint identity(1,1)  NOT NULL,
	Description nvarchar(20)
)
;

CREATE TABLE Roles ( 
	ID tinyint identity(1,1)  NOT NULL,
	Description nvarchar(20)
)
;

CREATE TABLE Users ( 
	Login nvarchar(50),
	Password nvarchar(50),
	PersonID smallint,
	RoleID tinyint
)
;


ALTER TABLE Applications ADD CONSTRAINT PK_Applications 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE ApplicationStatuses ADD CONSTRAINT PK_ApplicationStatuses 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE Cars ADD CONSTRAINT PK_Cars 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE EventLog ADD CONSTRAINT PK_EventLog 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE MessageStatuses ADD CONSTRAINT PK_MessageStatuses 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE Persons ADD CONSTRAINT PK_Persons 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE Places ADD CONSTRAINT PK_Places 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE PlaceStatuses ADD CONSTRAINT PK_PlaceStatuses 
	PRIMARY KEY CLUSTERED (ID)
;

ALTER TABLE Roles ADD CONSTRAINT PK_Roles 
	PRIMARY KEY CLUSTERED (ID)
;



ALTER TABLE Applications ADD CONSTRAINT FK_Applications_ApplicationStatuses 
	FOREIGN KEY (StatusID) REFERENCES ApplicationStatuses (ID)
;

ALTER TABLE Applications ADD CONSTRAINT FK_Applications_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE ApprovedApplications ADD CONSTRAINT FK_ApprovedApplications_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE ApprovedApplications ADD CONSTRAINT FK_ApprovedApplications_Places 
	FOREIGN KEY (PlaceID) REFERENCES Places (ID)
;

ALTER TABLE Cars ADD CONSTRAINT FK_Cars_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE Notifications ADD CONSTRAINT FK_Notifications_MessageStatuses 
	FOREIGN KEY (MessageStatusID) REFERENCES MessageStatuses (ID)
;

ALTER TABLE Notifications ADD CONSTRAINT FK_Notifications_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE Persons ADD CONSTRAINT FK_Persons_Places 
	FOREIGN KEY (PlaceID) REFERENCES Places (ID)
;

ALTER TABLE Places ADD CONSTRAINT FK_Places_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE Places ADD CONSTRAINT FK_Places_PlaceStatuses 
	FOREIGN KEY (StatusID) REFERENCES PlaceStatuses (ID)
;

ALTER TABLE Users ADD CONSTRAINT FK_Users_Persons 
	FOREIGN KEY (PersonID) REFERENCES Persons (ID)
;

ALTER TABLE Users ADD CONSTRAINT FK_Users_Roles 
	FOREIGN KEY (RoleID) REFERENCES Roles (ID)
;
