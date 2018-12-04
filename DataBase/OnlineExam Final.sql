CREATE DATABASE OnlineExamDb

USE OnlineExamDb
-----------------------------------------------------------------------------------------------
---User
--CREATE TABLE userTypeTable
--(
--Id int IDENTITY (1,1) PRIMARY KEY,
--Name varchar(200)
--)

CREATE TABLE dbo.Users(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(50),
	UserName varchar(50),
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
	CONSTRAINT [FK_UserUser] FOREIGN KEY(CreateById) REFERENCES Users (Id)
)
-----------------------------------------------------------------------------------------------
--Country City
CREATE TABLE Countries
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CountryUser] FOREIGN KEY(CreateById) REFERENCES Users (Id)
)

CREATE TABLE Cities
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CountryId int,
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CityCountry] FOREIGN KEY(CreateById) REFERENCES Countries (Id),
CONSTRAINT [FK_CityUser] FOREIGN KEY(CreateById) REFERENCES Users (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE Organizations(
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
CONSTRAINT [FK_OrganiaationUser] FOREIGN KEY(CreateById) REFERENCES Users (Id)
)

CREATE TABLE Courses(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
Name varchar(100),
Code varchar(50),
CourseDuration float,
Credit int,
Fee float,
Outline varchar(MAX),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CourseUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_CourseOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id)
)


CREATE TABLE Tags
(
Id int IDENTITY (1,1) PRIMARY KEY,
Name varchar(200),
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_TagUser] FOREIGN KEY(CreateById) REFERENCES Users (Id)
)

CREATE TABLE CourseTags(
TagId int,
CourseId int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_CourseTagLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_CourseTagTag] FOREIGN KEY(TagId) REFERENCES Tags (Id),
CONSTRAINT [FK_CourseTagCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id)
)

CREATE TABLE Batchs(
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
CONSTRAINT [FK_BatchTagLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_BatchOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
CONSTRAINT [FK_BatchCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE Trainers(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
--CourseId int,
--BatchId int,
Name varchar(50),
--Lead int,
ConatactNo varchar(150),
Email varchar(150),
AddressLine1 varchar(max),
AddressLine2 varchar(max),
CityId  int,			-- Cities
PostalCode varchar(50),	-- postalCodeTable
CountryId int,		-- Countries
[Image] varchar(max),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_TrainerUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_TrainerOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
--CONSTRAINT [FK_TrainerCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
--CONSTRAINT [FK_TrainerBatch] FOREIGN KEY(BatchId) REFERENCES Batchs (Id),
CONSTRAINT [FK_TrainerCountry] FOREIGN KEY(CountryId) REFERENCES Countries (Id),
CONSTRAINT [FK_TrainerCity] FOREIGN KEY(CityId) REFERENCES Cities (Id)
)
--AssignCourseTrainers
CREATE TABLE AssignCourseTrainers(
Id int IDENTITY (1,1) PRIMARY KEY,
CourseId int,
TrainerId int,
Lead int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AssignCourseTrainerUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AssignCourseTrainerCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
CONSTRAINT [FK_AssignCourseTrainerTrainer] FOREIGN KEY(TrainerId) REFERENCES Trainers (Id)
)

--AssignBatcheTrainers
CREATE TABLE AssignBatchTrainers(
Id int IDENTITY (1,1) PRIMARY KEY,
BatchId int,
TrainerId int,
--Lead int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AssignBatchTrainerUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AssignBatchTrainerBatch] FOREIGN KEY(BatchId) REFERENCES Batchs (Id),
CONSTRAINT [FK_AssignBatchTrainerTrainer] FOREIGN KEY(TrainerId) REFERENCES Trainers (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE Participants(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
--CourseId int,
--BatchId int,
Name varchar(50),
RegNo varchar(10),
ConatactNo varchar(150),
Email varchar(150),
AddressLine1 varchar(max),
AddressLine2 varchar(max),
CityId  int,			-- Cities
PostalCode varchar(50),	-- postalCodeTable
CountryId int,		-- Countries
Profession varchar(100),
HighestAcademic varchar(100),
[Image] varchar(max),		-- datatype ???????????	
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_ParticipantUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_ParticipantOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
--CONSTRAINT [FK_ParticipantCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
--CONSTRAINT [FK_ParticipantBatch] FOREIGN KEY(BatchId) REFERENCES Batchs (Id),
CONSTRAINT [FK_ParticipantCountry] FOREIGN KEY(CountryId) REFERENCES Countries (Id),
CONSTRAINT [FK_ParticipantCity] FOREIGN KEY(CityId) REFERENCES Cities (Id)
)

--AssignBatchParticipants
CREATE TABLE AssignBatchParticipants(
Id int IDENTITY (1,1) PRIMARY KEY,
BatchId int,
ParticipantId int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AssignBatchParticipantUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AssignBatchParticipantBatch] FOREIGN KEY(BatchId) REFERENCES Batchs (Id),
CONSTRAINT [FK_AssignBatchParticipantParticipant] FOREIGN KEY(ParticipantId) REFERENCES Participants (Id)
)

--AssignCourseParticipants
CREATE TABLE AssignCourseParticipants(
Id int IDENTITY (1,1) PRIMARY KEY,
CourseId int,
ParticipantId int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AssignCourseParticipantUser] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AssignCourseParticipantBatch] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
CONSTRAINT [FK_AssignCourseParticipantParticipant] FOREIGN KEY(ParticipantId) REFERENCES Participants (Id)
)

-----------------------------------------------------------------------------------------------

CREATE TABLE Exams(
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
CONSTRAINT [FK_ExamLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_ExamOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
CONSTRAINT [FK_ExamCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id)
)

CREATE TABLE Questions(
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
CONSTRAINT [FK_QuestionLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_QuestionOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
CONSTRAINT [FK_QuestionCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
CONSTRAINT [FK_QuestionExam] FOREIGN KEY(ExamId) REFERENCES Exams (Id)
)

CREATE TABLE Answers(
Id int IDENTITY (1,1) PRIMARY KEY,
QuestionId int,
[Order] int,
Answer varchar(max),
Result int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AnswerQuestion] FOREIGN KEY(QuestionId) REFERENCES Questions (Id)
)

--ScheduleExam
CREATE TABLE ScheduleExams(
Id int IDENTITY (1,1) PRIMARY KEY,
BatchId int,
ExamId int,
ExamDate date,
ExamTime time,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_ScheduleExamLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_ScheduleExamBatch] FOREIGN KEY(BatchId) REFERENCES Batchs (Id),
CONSTRAINT [FK_ScheduleExamExam] FOREIGN KEY(ExamId) REFERENCES Exams (Id)
)

-----------------------------------------------------------------------------------------------
--AttendExam

CREATE TABLE AttendExams(
Id int IDENTITY (1,1) PRIMARY KEY,
OrganiaationId int,
CourseId int,
ParticipantId int,
ExamId int,
AttendExamDate date,
StartTime time,
EndTime time,
TotalMarks float,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AttendExamLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AttendExamOrganiaation] FOREIGN KEY(OrganiaationId) REFERENCES Organizations (Id),
CONSTRAINT [FK_AttendExamCourse] FOREIGN KEY(CourseId) REFERENCES Courses (Id),
CONSTRAINT [FK_AttendExamExam] FOREIGN KEY(ExamId) REFERENCES Exams (Id),
CONSTRAINT [FK_AttendExamParticipant] FOREIGN KEY(ParticipantId) REFERENCES Participants (Id)
)

CREATE TABLE AttendQuestions(
Id int IDENTITY (1,1) PRIMARY KEY,
AttendExamId int,
QuestionId int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AttendQuestionLogin] FOREIGN KEY(CreateById) REFERENCES Users (Id),
CONSTRAINT [FK_AttendQuestionAttendExam] FOREIGN KEY(AttendExamId) REFERENCES AttendExams (Id),
CONSTRAINT [FK_AttendQuestionQuestion] FOREIGN KEY(QuestionId) REFERENCES Questions (Id)
)

CREATE TABLE AttendAnswers(
Id int IDENTITY (1,1) PRIMARY KEY,
AttendQuestionId int,
--QuestionId int,
AnswerId int,
AttendAnswer int,
[Status] varchar(1) default 'A',
CreateById int,
CreateDate smalldatetime,
CONSTRAINT [FK_AttendAnswerAttendQuestion] FOREIGN KEY(AttendQuestionId) REFERENCES AttendQuestions (Id),
--CONSTRAINT [FK_AnswerQuestion] FOREIGN KEY(QuestionId) REFERENCES Questions (Id)
CONSTRAINT [FK_AttendAnswerAnswers] FOREIGN KEY(AnswerId) REFERENCES Answers (Id),

)
