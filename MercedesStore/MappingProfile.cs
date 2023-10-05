using AutoMapper;
using MercedesStore.Entities.Models;
using MercedesStore.Shared.DTO;

namespace MercedesStore
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<Auto, AutoDTO>();
            CreateMap<Review, ReviewDTO>();
                
        }
    }
}
