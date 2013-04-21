CREATE TABLE tb_location
(
	PK_Location INT IDENTITY(1,1),
	FK_User INT NOT NULL,
	Location NVARCHAR(max) NOT NULL
)

CREATE TABLE tb_user
(
	PK_User int IDENTITY(1,1),
	FK_User_Security_Type int NOT NULL,
	Email NVARCHAR(MAX) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	UserName NVARCHAR(MAX) NOT NULL,
	CreateTime DATETIME NOT NULL,
	ModTime DATETIME Null,
	ContactPublic BIT NOT NULL,
	LocationPublic BIT NOT NULL,
	Notifications BIT NOT NULL
)

CREATE TABLE tb_user_security_type
(
	PK_User_Security_Type int IDENTITY(1,1),
	SecurityType NVARCHAR(MAX) NOT NULL
)

CREATE TABLE tb_neo_observations
(
	PK_NEO_Observations INT IDENTITY(1,1),
	FK_User INT NOT NULL,
	FK_NEO INT NULL,
	Name NVARCHAR NOT NULL,
	DiscoveryDate DATETIME NOT NULL,
	RightAscension NVARCHAR(MAX) NOT NULL,
	Declination NVARCHAR(MAX) NOT NULL,
	Visibility NVARCHAR(MAX) NOT NULL,
	CreateDate DATETIME NOT NULL,
	Notes NVARCHAR NOT NULL,
	Distance INT NULL
)

CREATE TABLE tb_neo_observations_locations
(
	PK_NEO_Observations_Locations INT IDENTITY(1,1),
	FK_NEO_Observations INT NOT NULL,
	Longitude FLOAT NOT NULL,
	Latitude FLOAT NOT NULL,
	Altitude FLOAT NOT NULL,
	ObservatoryCode NVARCHAR(4) NULL,
	Geocentric bit NOT NULL
)

CREATE TABLE tblk_observatory
(
	PK_Observatory INT IDENTITY(1,1),
	ObservatoryCode NVARCHAR(4) NOT NULL,
	Longitude FLOAT NOT NULL,
	SINE FLOAT NOT NULL,
	COSINE FLOAT NOT NULL
)


CREATE TABLE tb_neo_relationships_votes
(
	PK_NEO_Relationships_Votes INT IDENTITY(1,1),
	FK_NEO_Relationships INT NOT NULL,
	FK_USER INT NOT NULL,
	Vote bit NOT NULL,
	CreateTime DATETIME NOT NULL
)

CREATE TABLE tb_neo_relationships
(
	PK_NEO_Relationships INT IDENTITY(1,1),
	FK_NEO_Observations_One INT NOT NULL,
	FK_NEO_Observations_TWO INT NOT NULL,
	Vote INT NOT NULL,
)

CREATE TABLE tb_neo
(
	PK_NEO INT IDENTITY(1,1),
	DesireabilityScore INT NULL,
	NumberOfObservations INT NOT NULL,
	[Rank] INT NOT NULL,
	Arc NVARCHAR(MAX) NULL
)

CREATE TABLE tb_images
(
	PK_Images INT IDENTITY(1,1),
	FK_NEO_Observations INT NOT NULL,
	URL NVARCHAR(MAX) NOT NULL
)