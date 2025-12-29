using Microsoft.Extensions.Logging;
using PizzaCs.Core.Models.Dtos.MenuItems;
using PizzaCs.Core.Services.Base;
using PizzaCs.Core.Services.Interfaces;
using PizzaCs.Infrastructure.Models.Entities;
using PizzaCs.Infrastructure.Repository.Interfaces;

namespace PizzaCs.Core.Services;

public class MenuItemService : BaseService<MenuItemEfc, MenuItemDto>, IMenuItemService
{
    public MenuItemService(IMenuItemRepository repository, ILogger<IServiceWrapper> logger)
        : base(repository, logger) { }
}
