using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee
{
    public class PopularBrews : ViewComponent
    {
        public IMenuService menu;

        public PopularBrews(IMenuService menuSvc)
        {
            this.menu = menuSvc;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            //var menu = new MenuService();
            return View(menu.GetPopularItems().Take(count));
        }
    }
}
