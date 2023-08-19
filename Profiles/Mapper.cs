using ApiPreview_ThanhTan.Model;
using AutoMapper;

namespace ApiPreview_ThanhTan.Profiles
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Books,BooksRequestModel>().ReverseMap();
        }   
    }
}
