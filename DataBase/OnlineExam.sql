CREATE DATABASE OnlineExamDb

USE OnlineExamDb

CREATE TABLE organiaationTable(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(100),
Code varchar(50),
[Address] varchar(MAX),
ConatactNo varchar(150),
About nvarchar(MAX),
Logo varchar(MAX)
 
)

CREATE TABLE courseTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
Name varchar(100),
Code varchar(50),
CourseDuration float,
Credit int,
Outline text,		-- datatype ???????????	
CONSTRAINT [FK_CourseOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id)
)


CREATE TABLE tagTable
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name text
)

CREATE TABLE courseTagTable(
TagId int,
CourseId int
CONSTRAINT [FK_courseTagTag] FOREIGN KEY(TagId) REFERENCES tagTable (Id),
CONSTRAINT [FK_courseTagCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)

CREATE TABLE batchTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
BatchNo int,
[Description] text,
StartDate date,
EndDate date,
CONSTRAINT [FK_batchOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_batchCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)

CREATE TABLE trainerTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
BatchId int,
Name varchar(50),
ConatactNo varchar(150),
Email varchar(150),
AddressLine1 varchar(max),
AddressLine2 varchar(max),
City  varchar(50),			-- cityTable
PostalCode varchar(50),	-- postalCodeTable
Country varchar(50),		-- countryTable
[Image] varchar(max),		-- datatype ???????????	
CONSTRAINT [FK_trainerOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_trainerCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id),
CONSTRAINT [FK_trainerbatch] FOREIGN KEY(BatchId) REFERENCES batchTable (Id)
)

CREATE TABLE participantTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
BatchId int,
Name varchar(50),
RegNo varchar(10),
ConatactNo varchar(150),
Email varchar(150),
AddressLine1 varchar(max),
AddressLine2 varchar(max),
City  varchar(50),			-- cityTable
PostalCode varchar(50),		-- postalCodeTable
Country varchar(50),		-- countryTable
Profession varchar(100),
HighestAcademic varchar(100),
[Image] varchar(max),		-- datatype ???????????	
CONSTRAINT [FK_participantOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_participantCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id),
CONSTRAINT [FK_participantbatch] FOREIGN KEY(BatchId) REFERENCES batchTable (Id)
)

CREATE TABLE examTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
ExamType varchar(50),
Code varchar(50),
Topic varchar(max),
FullMark int,
Duration time,				-- datatype ???????????
CONSTRAINT [FK_examOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_examCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)
