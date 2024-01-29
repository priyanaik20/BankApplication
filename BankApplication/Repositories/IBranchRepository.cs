using BankApplication.Entities;

namespace BankApplication.Repositories
{
    public interface IBranchRepository
    {
        public Task<int> AddBranchAsync(Branch branch);
    }
}
