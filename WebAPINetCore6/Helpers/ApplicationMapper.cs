using AutoMapper;
using WebAPINetCore6.Data;
using WebAPINetCore6.Models;

namespace WebAPINetCore6.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
