using ContactsSync.Model;

namespace ContactsSync.Interface
{
    public interface IAllContracts
    {
        Task<bool> Save(List<AllContractsVM> obj);
        Task<List<AllContractsVM>> GetList();

    }
}
