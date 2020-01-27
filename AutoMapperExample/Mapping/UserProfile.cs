using AutoMapper;
using AutoMapperExample.Models;
using AutoMapperExample.View;

namespace AutoMapperExample.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                //Quando o nome da propriedade for diferente
                .ForMember(destino => destino.Email, user => user.MapFrom(src => src.EmailAddress))
                //Ignorar valores, por ex no model tem LastName na view model não
                .ForSourceMember(model => model.LastName, opt => opt.DoNotValidate())
                //Adicionar Condições
                .ForMember(destino => destino.Admin, destino => destino.MapFrom(x => x.Admin ?? false))
                .ReverseMap();
        }
    }
}
