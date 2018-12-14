using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using OnlineExam.App.Models;
using OnlineExam.Models.Models;

namespace OnlineExam.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg =>
            {
                
                //
                cfg.CreateMap<BatchCreateViewModel, Batch>();
                cfg.CreateMap<Batch, BatchCreateViewModel>();

                //
                cfg.CreateMap<CourseCreateViewModel, Course>();
                cfg.CreateMap<Course, CourseCreateViewModel>();
                //
                cfg.CreateMap<ExamCreateViewModel, Exam>();
                cfg.CreateMap<Exam, ExamCreateViewModel>();

                //Organization
                cfg.CreateMap<OrganizationCreateViewModel, Organization>();
                cfg.CreateMap<Organization, OrganizationCreateViewModel>();
                //
                cfg.CreateMap<ParticipantCreateViewModel, Participant>();
                cfg.CreateMap<Participant, ParticipantCreateViewModel>();

                //
                cfg.CreateMap<QuestionAnswerCreateViewModel, Question>();
                cfg.CreateMap<Question, QuestionAnswerCreateViewModel>();

                ////
                //cfg.CreateMap<ResultCreateViewModel, Result>();
                //cfg.CreateMap<Result, ResultCreateViewModel>();
                //
                cfg.CreateMap<TrainerCreateViewModel, Trainer>();
                cfg.CreateMap<Trainer, TrainerCreateViewModel>();


            });
        }
    }
}
