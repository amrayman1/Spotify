using AutoMapper;
using Profile_and_Singers.Dtos;
using Profile_and_Singers.Models;

namespace Profile_and_Singers.Helper
{
    public class DomainProfile : Profile
    {
        protected DomainProfile()
        {
            CreateMap<Music, MusicDto>();
            CreateMap<MusicDto, Music>();
            CreateMap<Singer,SingerDto>().ForMember(dto=>dto.musics,opt=>opt.MapFrom(x=>x.singerMusics.Select(y=>y.musics).ToList()));
            CreateMap<SingerDto, Singer>();
            
        }
    }
}
