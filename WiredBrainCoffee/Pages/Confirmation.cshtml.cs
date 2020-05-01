﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiredBrainCoffee.Pages
{
     public class ConfirmationModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGetContact()
        {
            Message = "Your email was sent to our team.";
        }


        public void OnGetSubscribe()
        {
            Message = "Your have been added to the mailing list.";
        }
    }
}