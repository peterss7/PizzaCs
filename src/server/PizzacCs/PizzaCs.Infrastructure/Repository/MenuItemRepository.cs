using Microsoft.Extensions.Logging;
using PizzaCs.Infrastructure.Data;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Base;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Infrastructure.Repository;

public class MenuItemRepository : BaseRepository<MenuItemEfc>, IMenuItemRepository        
{
    public MenuItemRepository(PizzaContext context, ILogger<IRepositoryWrapper> logger)
        : base(context, logger) { }
}
