﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact  Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                Message = "Your message has been sent.";
            }
        }

    }
}
