using AutoMapper;
using ContactsSync.Database;
using ContactsSync.Interface;
using ContactsSync.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactsSync.Repository
{
    public class AllContractService : IAllContracts
    {
        private ContactsSyncContext _context;
        private IMapper _mapper;

        public AllContractService(ContactsSyncContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Save(List<AllContractsVM> obj)
        {
            foreach (var item in obj)
            {
                var allContracts = _mapper.Map<AllContracts>(item);
                var exists = await _context.AllContracts.Where(c => c.Email_Address == item.Email_Address).FirstOrDefaultAsync();
                if (exists != null)
                {
                    allContracts.Id = exists.Id;
                    _context.AllContracts.Update(allContracts);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.AllContracts.Add(allContracts);
                    await _context.SaveChangesAsync();
                }
            }

            return true;

        }

        public async Task<List<AllContractsVM>> GetList()
        {
            var data = await _context.AllContracts.ToListAsync();
            return _mapper.Map<List<AllContractsVM>>(data);

        }
    }
}
