using BankApplication.Entities;

namespace BankApplication.Repositories.Impl
{
    public class BranchRepository : IBranchRepository
    {
        private readonly BankingApplicationContext context;
        public async Task<int> AddBranchAsync(Branch branch)
        {
            context.Branches.Add(branch);
            await context.SaveChangesAsync();
            return branch.BranchId;
        }
    }
}
