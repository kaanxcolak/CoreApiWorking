using AutoMapper;
using EntityLayer.Models;
using EntityLayer.ViewModels;

namespace EntityLayer.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Student,StudentVM>().ReverseMap();    
        }

    }
}
