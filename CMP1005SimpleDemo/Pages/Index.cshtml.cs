using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CMP1005SimpleDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private string userName = string.Empty;
        private string userPath = string.Empty;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string data = "Hello!";

        public string GetDate()
        {
            var x = typeof(string);

            return $"Hello World";
        }

        public string GetName()
        {
            return userName;
        }

        public string GetPath()
        {
            return userPath;
        }

        public void OnGet()
        {
            if (Request.Query.ContainsKey("name"))
            {
                userName = Request.Query["name"];
            }

            if (Request.Path != string.Empty)
            {
                userPath = Request.Path.Value;
            }
        }

        public void OnPost()
        {
            if (Request.Form.ContainsKey("name"))
            {
                userName = Request.Form["name"] + " POST";
            }

            if (Request.Path != string.Empty)
            {
                userPath = Request.Path.Value + " POST";
            }
        }
    }
}
