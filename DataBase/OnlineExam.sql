CREATE DATABASE OnlineExamDb

USE OnlineExamDb
-----------------------------------------------------------------------------------------------
---User
--CREATE TABLE userTypeTable
--(
--Id int IDENTITY (1,1) PRIMARY KEY,
--Name varchar(200)
--)

CREATE TABLE dbo.userLoginTable(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(50),
	UserLoginName varchar(50),
	--UserTypeId int,
	UserType varchar(25),
	[Password] varchar(8),
	ConfirmPassword varchar(8),
	ContactNo varchar(11),
	Email varchar(50),
	CreateDate smalldatetime,
	CreateById int,
	LastLogIn smalldatetime,
	[Status] varchar(1) default 'A',
	--CONSTRAINT [FK_UserUserType] FOREIGN KEY(UserTypeId) REFERENCES userTypeTable (Id),
	CONSTRAINT [FK_UserUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id)
)
-----------------------------------------------------------------------------------------------
--Country City
CREATE TABLE countryTable
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CountryUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id)
)

CREATE TABLE cityTable
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CountryId int,
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CityCountry] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_CityUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE organiaationTable(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(100),
Code varchar(50),
[Address] varchar(MAX),
ConatactNo varchar(150),
About nvarchar(MAX),
Logo varchar(MAX),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_OrganiaationUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id)
)

CREATE TABLE courseTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
Name varchar(100),
Code varchar(50),
CourseDuration float,
Credit int,
Outline varchar(MAX),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CourseUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_CourseOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id)
)

CREATE TABLE tagTable
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_TagUserLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id)
)

CREATE TABLE courseTagTable(
TagId int,
CourseId int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CourseTagLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_CourseTagTag] FOREIGN KEY(TagId) REFERENCES tagTable (Id),
CONSTRAINT [FK_CourseTagCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)

CREATE TABLE batchTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
BatchNo int,
[Description] varchar(MAX),
StartDate date,
EndDate date,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_BatchTagLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_BatchOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_BatchCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)

-----------------------------------------------------------------------------------------------

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
CityId  int,			-- cityTable
PostalCode varchar(50),	-- postalCodeTable
CountryId int,		-- countryTable
[Image] varchar(max),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_TrainerTagLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_TrainerOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_TrainerCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id),
CONSTRAINT [FK_TrainerBatch] FOREIGN KEY(BatchId) REFERENCES batchTable (Id),
CONSTRAINT [FK_TrainerCountry] FOREIGN KEY(CountryId) REFERENCES countryTable (Id),
CONSTRAINT [FK_TrainerCity] FOREIGN KEY(CityId) REFERENCES cityTable (Id)
)

-----------------------------------------------------------------------------------------------

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
CityId  int,			-- cityTable
PostalCode varchar(50),	-- postalCodeTable
CountryId int,		-- countryTable
Profession varchar(100),
HighestAcademic varchar(100),
[Image] varchar(max),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_ParticipantTagLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_ParticipantOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_ParticipantCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id),
CONSTRAINT [FK_ParticipantBatch] FOREIGN KEY(BatchId) REFERENCES batchTable (Id),
CONSTRAINT [FK_ParticipantCountry] FOREIGN KEY(CountryId) REFERENCES countryTable (Id),
CONSTRAINT [FK_ParticipantCity] FOREIGN KEY(CityId) REFERENCES cityTable (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE examTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
ExamType varchar(50),
Code varchar(50),
Topic varchar(max),
FullMark int,
Duration time,				-- datatype ???????????
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_ExamLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_ExamOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_ExamCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id)
)

CREATE TABLE questionTable(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
ExamId int,
Mark float,
[Order] int,
Question varchar(max),
QuestionType varchar(1),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_QuestionLogin] FOREIGN KEY(CreateById) REFERENCES userLoginTable (Id),
CONSTRAINT [FK_QuestionOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES organiaationTable (Id),
CONSTRAINT [FK_QuestionCourse] FOREIGN KEY(CourseId) REFERENCES courseTable (Id),
CONSTRAINT [FK_QuestionExam] FOREIGN KEY(ExamId) REFERENCES examTable (Id)
)

CREATE TABLE answerTable(
Id int IDENTITY (1,1) PRIMARY KEY,
QuestionId int,
[Order] int,
Answer varchar(max),
Result bit default 1,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AnswerQuestion] FOREIGN KEY(QuestionId) REFERENCES questionTable (Id)
)

