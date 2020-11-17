using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public bool Result { get; private set; }

        public AlarmParse AlarmParse { get; private set; }

        public void OnGet()
        {
            Message = "Enter your message here";
            //AlarmParse = new AlarmParse();
            //Result = false;
        }

        public void OnPost()
        {
            Message = Request.Form[nameof(Message)];

            AlarmParse = AlarmParse.ParseMessage(Message);

            Result = true;


        }
    }
}
