﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevChatter.DevStreams.Web.Pages.Channels
{
    public class DetailsModel : PageModel
    {
        public void OnGet(int id)
        {
            // TODO: Load the details of this channel
            Name = "Super Awesome Super Show";
        }

        public string Name { get; set; }
    }
}