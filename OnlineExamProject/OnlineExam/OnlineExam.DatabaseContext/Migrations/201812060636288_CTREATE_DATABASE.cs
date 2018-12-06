namespace OnlineExam.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CTREATE_DATABASE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(),
                        Order = c.Int(),
                        Answer1 = c.String(),
                        Result = c.Int(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.AttendAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttendQuestionId = c.Int(),
                        AnswerId = c.Int(),
                        AttendAnswer1 = c.Int(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.AnswerId)
                .ForeignKey("dbo.AttendQuestions", t => t.AttendQuestionId)
                .Index(t => t.AttendQuestionId)
                .Index(t => t.AnswerId);
            
            CreateTable(
                "dbo.AttendQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttendExamId = c.Int(),
                        QuestionId = c.Int(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AttendExams", t => t.AttendExamId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId)
                .Index(t => t.AttendExamId)
                .Index(t => t.QuestionId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AttendExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        CourseId = c.Int(),
                        ParticipantId = c.Int(),
                        ExamId = c.Int(),
                        AttendExamDate = c.DateTime(),
                        StartTime = c.Time(precision: 7),
                        EndTime = c.Time(precision: 7),
                        TotalMarks = c.Double(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                        Organization_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Exams", t => t.ExamId)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Participants", t => t.ParticipantId)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.ParticipantId)
                .Index(t => t.ExamId)
                .Index(t => t.User_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        Name = c.String(),
                        Code = c.String(),
                        CourseDuration = c.Double(),
                        Credit = c.Int(),
                        Fee = c.Double(),
                        Outline = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                        Organization_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.AssignCourseParticipants",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Cours_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.CourseId, t.ParticipantId })
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.ParticipantId)
                .Index(t => t.Cours_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        Name = c.String(),
                        RegNo = c.String(),
                        ConatactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        CityId = c.Int(),
                        PostalCode = c.String(),
                        CountryId = c.Int(),
                        Profession = c.String(),
                        HighestAcademic = c.String(),
                        Image = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Organization_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.Organization_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AssignBatchParticipants",
                c => new
                    {
                        BatchId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.BatchId, t.ParticipantId })
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.BatchId)
                .Index(t => t.ParticipantId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        CourseId = c.Int(),
                        BatchNo = c.Int(),
                        Description = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                        Organization_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.AssignBatchTrainers",
                c => new
                    {
                        BatchId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.BatchId, t.TrainerId })
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: true)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BatchId)
                .Index(t => t.TrainerId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        Name = c.String(),
                        ConatactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        CityId = c.Int(),
                        PostalCode = c.String(),
                        CountryId = c.Int(),
                        Image = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Organization_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.Organization_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AssignCourseTrainers",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        Lead = c.Int(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Cours_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.CourseId, t.TrainerId })
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.TrainerId)
                .Index(t => t.Cours_Id)
                .Index(t => t.User_Id);
            
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
                        CreateDate = c.DateTime(),
                        CreateById = c.Int(),
                        LastLogIn = c.DateTime(),
                        Status = c.String(),
                        User1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User1_Id)
                .Index(t => t.User1_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CountryId = c.Int(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.CountryId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.CourseTags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Cours_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.TagId, t.CourseId })
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.TagId)
                .Index(t => t.Cours_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        CourseId = c.Int(),
                        ExamType = c.String(),
                        Code = c.String(),
                        Topic = c.String(),
                        FullMark = c.Int(),
                        Duration = c.Time(precision: 7),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Cours_Id = c.Int(),
                        Organization_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Cours_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.User_Id);
            
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
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganiaationId = c.Int(),
                        CourseId = c.Int(),
                        ExamId = c.Int(),
                        Mark = c.Double(),
                        Order = c.Int(),
                        Question1 = c.String(),
                        QuestionType = c.String(),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        Cours_Id = c.Int(),
                        Organization_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Exams", t => t.ExamId)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.ExamId)
                .Index(t => t.Cours_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ScheduleExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchId = c.Int(),
                        ExamId = c.Int(),
                        ExamDate = c.DateTime(),
                        ExamTime = c.Time(precision: 7),
                        Status = c.String(),
                        CreateById = c.Int(),
                        CreateDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batches", t => t.BatchId)
                .ForeignKey("dbo.Exams", t => t.ExamId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BatchId)
                .Index(t => t.ExamId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttendExams", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.AttendExams", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.AssignCourseParticipants", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.AssignBatchParticipants", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Batches", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.Users", "User1_Id", "dbo.Users");
            DropForeignKey("dbo.Trainers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Participants", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Exams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ScheduleExams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ScheduleExams", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.ScheduleExams", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.Organizations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Trainers", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Questions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Questions", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Questions", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.Questions", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.AttendQuestions", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Participants", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Exams", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Cours", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Batches", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.AttendExams", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Exams", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.AttendExams", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.CourseTags", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Tags", "User_Id", "dbo.Users");
            DropForeignKey("dbo.CourseTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.CourseTags", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.Cours", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Cities", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Trainers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Participants", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Countries", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Trainers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Participants", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Batches", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AttendQuestions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AttendExams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AssignCourseTrainers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AssignCourseParticipants", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AssignBatchTrainers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AssignBatchParticipants", "User_Id", "dbo.Users");
            DropForeignKey("dbo.AssignCourseTrainers", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.AssignCourseTrainers", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.AssignBatchTrainers", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.AssignBatchTrainers", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.AssignBatchParticipants", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.AssignCourseParticipants", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.AttendQuestions", "AttendExamId", "dbo.AttendExams");
            DropForeignKey("dbo.AttendAnswers", "AttendQuestionId", "dbo.AttendQuestions");
            DropForeignKey("dbo.AttendAnswers", "AnswerId", "dbo.Answers");
            DropIndex("dbo.ScheduleExams", new[] { "User_Id" });
            DropIndex("dbo.ScheduleExams", new[] { "ExamId" });
            DropIndex("dbo.ScheduleExams", new[] { "BatchId" });
            DropIndex("dbo.Questions", new[] { "User_Id" });
            DropIndex("dbo.Questions", new[] { "Organization_Id" });
            DropIndex("dbo.Questions", new[] { "Cours_Id" });
            DropIndex("dbo.Questions", new[] { "ExamId" });
            DropIndex("dbo.Organizations", new[] { "User_Id" });
            DropIndex("dbo.Exams", new[] { "User_Id" });
            DropIndex("dbo.Exams", new[] { "Organization_Id" });
            DropIndex("dbo.Exams", new[] { "Cours_Id" });
            DropIndex("dbo.Tags", new[] { "User_Id" });
            DropIndex("dbo.CourseTags", new[] { "User_Id" });
            DropIndex("dbo.CourseTags", new[] { "Cours_Id" });
            DropIndex("dbo.CourseTags", new[] { "TagId" });
            DropIndex("dbo.Countries", new[] { "User_Id" });
            DropIndex("dbo.Cities", new[] { "User_Id" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Users", new[] { "User1_Id" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "User_Id" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "Cours_Id" });
            DropIndex("dbo.AssignCourseTrainers", new[] { "TrainerId" });
            DropIndex("dbo.Trainers", new[] { "User_Id" });
            DropIndex("dbo.Trainers", new[] { "Organization_Id" });
            DropIndex("dbo.Trainers", new[] { "CountryId" });
            DropIndex("dbo.Trainers", new[] { "CityId" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "User_Id" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "TrainerId" });
            DropIndex("dbo.AssignBatchTrainers", new[] { "BatchId" });
            DropIndex("dbo.Batches", new[] { "Cours_Id" });
            DropIndex("dbo.Batches", new[] { "Organization_Id" });
            DropIndex("dbo.Batches", new[] { "User_Id" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "User_Id" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "ParticipantId" });
            DropIndex("dbo.AssignBatchParticipants", new[] { "BatchId" });
            DropIndex("dbo.Participants", new[] { "User_Id" });
            DropIndex("dbo.Participants", new[] { "Organization_Id" });
            DropIndex("dbo.Participants", new[] { "CountryId" });
            DropIndex("dbo.Participants", new[] { "CityId" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "User_Id" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "Cours_Id" });
            DropIndex("dbo.AssignCourseParticipants", new[] { "ParticipantId" });
            DropIndex("dbo.Cours", new[] { "Organization_Id" });
            DropIndex("dbo.Cours", new[] { "User_Id" });
            DropIndex("dbo.AttendExams", new[] { "Cours_Id" });
            DropIndex("dbo.AttendExams", new[] { "Organization_Id" });
            DropIndex("dbo.AttendExams", new[] { "User_Id" });
            DropIndex("dbo.AttendExams", new[] { "ExamId" });
            DropIndex("dbo.AttendExams", new[] { "ParticipantId" });
            DropIndex("dbo.AttendQuestions", new[] { "User_Id" });
            DropIndex("dbo.AttendQuestions", new[] { "QuestionId" });
            DropIndex("dbo.AttendQuestions", new[] { "AttendExamId" });
            DropIndex("dbo.AttendAnswers", new[] { "AnswerId" });
            DropIndex("dbo.AttendAnswers", new[] { "AttendQuestionId" });
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
            DropTable("dbo.Cours");
            DropTable("dbo.AttendExams");
            DropTable("dbo.AttendQuestions");
            DropTable("dbo.AttendAnswers");
            DropTable("dbo.Answers");
        }
    }
}
