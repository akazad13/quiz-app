using AutoMapper;
using QuizApp.Models;
using QuizApp.Models.Dto;

namespace QuizApp.Infrastructure
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<UserForRegisterDto, User>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<CourseForUpdateDto, Course>();
            CreateMap<CourseForAddDto, Course>();
            CreateMap<QuizForAddDto, Quiz>();
            CreateMap<QuizForUpdateDto, Quiz>();
        }
    }
}
