using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository;

public class UserRepository: BaseRepository<UserEfc>, IUserRepository
{
    public UserRepository(PizzaContext context, ILogger<IRepositoryWrapper> logger)
        : base(context, logger)
    { }

    public override async Task<UserEfc?> GetByIdAsync(int id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
    }
}
