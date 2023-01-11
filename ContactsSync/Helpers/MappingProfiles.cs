using AutoMapper;
using ContactsSync.Database;
using ContactsSync.Model;

namespace ContactsSync.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AllContracts, AllContractsVM>().ReverseMap();
        }
    }
}
