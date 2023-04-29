using Application.Persistence.Contracts;
using Application.Persistence.Identity;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
    {
        private readonly PropagendaDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        public ProviderRepository(PropagendaDbContext dbContext, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor, IUserService userService) : base(dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }

        public async Task<Provider> GetProviderWithServices(int id)
        {
            var provider = await _dbContext.Providers
                .Include(p => p.Services)  
                    .ThenInclude(s => s.ServiceType)
                .FirstOrDefaultAsync(q => q.Id == id);

            return provider;
        }

        public new async Task<List<Provider>> GetAll()
        {
            var providers = await _dbContext.Providers.OrderByDescending(e => e.Id)
                .ToListAsync();
            return providers;
        }

        public async Task<IReadOnlyList<Provider>> GetAllToApprove()
        {
            return await _dbContext.Set<Provider>().Where(p => p.IsApproved == false).ToListAsync();
        }

        public async Task<IReadOnlyList<Provider>> GetAllByUser(string id)
        {
            return await _dbContext.Set<Provider>().Where(p => p.ApplicationUserId == id).ToListAsync();
        }

        new public async Task<Provider> Add(Provider provider)
        {
            await _dbContext.AddAsync(provider);
            var user = await _userService.GetUser(provider.ApplicationUserId);
            await _userManager.AddToRoleAsync(user, "Provider");

            await _dbContext.SaveChangesAsync();
            return provider;
        }

        public async Task ChangeActivationStatus(Provider provider, bool isActive)
        {
            provider.IsActive = isActive;
            _dbContext.Entry(provider).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangeApprovalStatus(Provider provider, bool isApproved)
        {
            provider.IsApproved = isApproved;
            if(isApproved == true)
            {
                provider.IsActive = true;
            }
            else provider.IsActive = false;
            _dbContext.Entry(provider).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
