namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_database_or_update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Answer1 = c.String(),
                        Result = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.QuestionId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AttendAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttendQuestionId = c.Int(nullable: false),
                        AnswerId = c.Int(nullable: false),
                        AttendAnswer1 = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.AnswerId, cascadeDelete: false)
                .ForeignKey("dbo.AttendQuestions", t => t.AttendQuestionId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.AttendQuestionId)
                .Index(t => t.AnswerId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AttendQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttendExamId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AttendExams", t => t.AttendExamId, cascadeDelete: false)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.AttendExamId)
                .Index(t => t.QuestionId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AttendExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        AttendExamDate = c.DateTime(nullable: false),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        TotalMarks = c.Double(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: false)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CourseId)
                .Index(t => t.ParticipantId)
                .Index(t => t.ExamId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        CourseDuration = c.Double(nullable: false),
                        Credit = c.Int(nullable: false),
                        Fee = c.Double(nullable: false),
                        Outline = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AssignCourseParticipants",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.ParticipantId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CourseId)
                .Index(t => t.ParticipantId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        RegNo = c.String(),
                        ConatactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        CityId = c.Int(nullable: false),
                        PostalCode = c.String(),
                        CountryId = c.Int(nullable: false),
                        Profession = c.String(),
                        HighestAcademic = c.String(),
                        Image = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AssignBatchParticipants",
                c => new
                    {
                        BatchId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.BatchId, t.ParticipantId })
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: false)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.BatchId)
                .Index(t => t.ParticipantId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        BatchNo = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CourseId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.AssignBatchTrainers",
                c => new
                    {
                        BatchId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.BatchId, t.TrainerId })
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: false)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.BatchId)
                .Index(t => t.TrainerId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        ConatactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        CityId = c.Int(nullable: false),
                        PostalCode = c.String(),
                        CountryId = c.Int(nullable: false),
                        Image = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Trainer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.CreateById)
                .Index(t => t.Trainer_Id);
            
            CreateTable(
                "dbo.AssignCourseTrainers",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        Lead = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.TrainerId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CourseId)
                .Index(t => t.TrainerId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                        UserType = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateById = c.Int(nullable: false),
                        LastLogIn = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CountryId = c.Int(nullable: false),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CountryId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.CourseTags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.CourseId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.TagId)
                .Index(t => t.CourseId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        ExamType = c.String(),
                        Code = c.String(),
                        Topic = c.String(),
                        FullMark = c.Int(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Organization_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CourseId)
                .Index(t => t.CreateById)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Address = c.String(),
                        ConatactNo = c.String(),
                        About = c.String(),
                        Logo = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        Mark = c.Double(nullable: false),
                        Order = c.Int(nullable: false),
                        Question1 = c.String(),
                        QuestionType = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.CourseId)
                .Index(t => t.ExamId)
                .Index(t => t.CreateById);
            
            CreateTable(
                "dbo.ScheduleExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        ExamDate = c.DateTime(nullable: false),
                        ExamTime = c.Time(nullable: false, precision: 7),
                        Status = c.String(),
                        CreateById = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: false)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreateById, cascadeDelete: false)
                .Index(t => t.BatchId)
                .Index(t => t.ExamId)
                .Index(t => t.CreateById);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AttendAnswers", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AttendQuestions", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AttendExams", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AttendExams", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AssignCourseParticipants", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Participants", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AttendExams", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.AssignCourseParticipants", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.AssignBatchParticipants", "CreateById", "dbo.Users");
            DropForeignKey("dbo.AssignBatchParticipants", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Batches", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Batches", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AssignBatchTrainers", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Trainers", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Trainers", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.AssignCourseTrainers", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Exams", "CreateById", "dbo.Users");
            DropForeignKey("dbo.ScheduleExams", "CreateById", "dbo.Users");
            DropForeignKey("dbo.ScheduleExams", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.ScheduleExams", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.Organizations", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Trainers", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Questions", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Questions", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Questions", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.Questions", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AttendQuestions", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Participants", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Exams", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Courses", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Batches", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.AttendExams", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Exams", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AttendExams", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.CourseTags", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Tags", "CreateById", "dbo.Users");
            DropForeignKey("dbo.CourseTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.CourseTags", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Cities", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Trainers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Participants", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Countries", "CreateById", "dbo.Users");
            DropForeignKey("dbo.Trainers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Participants", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.AssignCourseTrainers", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.AssignCourseTrainers", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AssignBatchTrainers", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.AssignBatchTrainers", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.AssignBatchParticipants", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.AssignCourseParticipants", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AttendQuestions", "AttendExamId", "dbo.AttendExams");
            DropForeignKey("dbo.AttendAnswers", "AttendQuestionId", "dbo.AttendQuestions");
            DropForeignKey("dbo.AttendAnswers", "AnswerId", "dbo.Answers");
            DropIndex("dbo.ScheduleExams", new[] { "CreateById" });
            DropIndex("dbo.ScheduleExams", new[] { "ExamId" });
            DropIndex("dbo.ScheduleExams", new[] { "BatchId" });
            DropIndex("dbo.Questions", new[] { "CreateById" });
            DropIndex("dbo.Questions", new[] { "ExamId" });
            DropIndex("dbo.Questions", new[] { "CourseId" });
            DropIndex("dbo.Questions", new[] { "OrganizationId" });
            DropIndex("dbo.Organizations", new[] { "CreateById" });
            DropIndex("dbo.Exams", new[] { "Organization_Id" });
            DropIndex("dbo.Exams", new[] { "CreateById" });
            DropIndex("dbo.Exams", new[] { "CourseId" });
            DropIndex("dbo.Tags", new[] { "CreateById" });
            DropIndex("dbo.CourseTags", new[] { "CreateById" });
            DropIndex("dbo.CourseTags", new[] { "CourseId" });
            DropIndex("dbo.CourseTags", new[] { "TagId" });
            DropIndex("dbo.Countries", new[] { "CreateById" });
            DropIndex("dbo.Cities", new[] { "CreateById" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "CreateById" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "TrainerId" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "CourseId" });
            DropIndex("dbo.Trainers", new[] { "Trainer_Id" });
            DropIndex("dbo.Trainers", new[] { "CreateById" });
            DropIndex("dbo.Trainers", new[] { "CountryId" });
            DropIndex("dbo.Trainers", new[] { "CityId" });
            DropIndex("dbo.Trainers", new[] { "OrganizationId" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "CreateById" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "TrainerId" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "BatchId" });
            DropIndex("dbo.Batches", new[] { "CreateById" });
            DropIndex("dbo.Batches", new[] { "CourseId" });
            DropIndex("dbo.Batches", new[] { "OrganizationId" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "CreateById" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "ParticipantId" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "BatchId" });
            DropIndex("dbo.Participants", new[] { "CreateById" });
            DropIndex("dbo.Participants", new[] { "CountryId" });
            DropIndex("dbo.Participants", new[] { "CityId" });
            DropIndex("dbo.Participants", new[] { "OrganizationId" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "CreateById" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "ParticipantId" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "CourseId" });
            DropIndex("dbo.Courses", new[] { "CreateById" });
            DropIndex("dbo.Courses", new[] { "OrganizationId" });
            DropIndex("dbo.AttendExams", new[] { "CreateById" });
            DropIndex("dbo.AttendExams", new[] { "ExamId" });
            DropIndex("dbo.AttendExams", new[] { "ParticipantId" });
            DropIndex("dbo.AttendExams", new[] { "CourseId" });
            DropIndex("dbo.AttendExams", new[] { "OrganizationId" });
            DropIndex("dbo.AttendQuestions", new[] { "CreateById" });
            DropIndex("dbo.AttendQuestions", new[] { "QuestionId" });
            DropIndex("dbo.AttendQuestions", new[] { "AttendExamId" });
            DropIndex("dbo.AttendAnswers", new[] { "CreateById" });
            DropIndex("dbo.AttendAnswers", new[] { "AnswerId" });
            DropIndex("dbo.AttendAnswers", new[] { "AttendQuestionId" });
            DropIndex("dbo.Answers", new[] { "CreateById" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.ScheduleExams");
            DropTable("dbo.Questions");
            DropTable("dbo.Organizations");
            DropTable("dbo.Exams");
            DropTable("dbo.Tags");
            DropTable("dbo.CourseTags");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Users");
            DropTable("dbo.AssignCourseTrainers");
            DropTable("dbo.Trainers");
            DropTable("dbo.AssignBatchTrainers");
            DropTable("dbo.Batches");
            DropTable("dbo.AssignBatchParticipants");
            DropTable("dbo.Participants");
            DropTable("dbo.AssignCourseParticipants");
            DropTable("dbo.Courses");
            DropTable("dbo.AttendExams");
            DropTable("dbo.AttendQuestions");
            DropTable("dbo.AttendAnswers");
            DropTable("dbo.Answers");
        }
    }
}
