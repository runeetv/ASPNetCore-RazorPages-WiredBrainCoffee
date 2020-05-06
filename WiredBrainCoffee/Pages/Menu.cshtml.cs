using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> Menu { get; set; }
        public IMenuService menuService;
        private ILogger<MenuModel> logger;

        public MenuModel(IMenuService menuSvc , ILogger<MenuModel> logger)
        {
            this.menuService= menuSvc;
            this.logger = logger; 
        }
        public void OnGet()
        {
            try
            {
                //var menuService = new MenuService();
                Menu = menuService.GetMenuItems();
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.LogDebug("Could not retrieve menu",Menu);
            }
        }
    }
}
