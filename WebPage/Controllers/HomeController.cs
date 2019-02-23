using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebPage.Models;
using Newtonsoft.Json;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        [Route("titles")]
        public IActionResult Index()
        {
            ApiHelper helper = new ApiHelper();
            var json= helper.GetRequest("titles");
            List<JobTitle> titles = JsonConvert.DeserializeObject<List<JobTitle>>(json);
            return View(titles);
        }

        [Route("employees/{id}")]
        public IActionResult Employee(int id)
        {
            ApiHelper helper = new ApiHelper();
            ViewData["PageTitle"]= helper.GetRequest("title/" + id);


            var json = helper.GetRequest("employees/" + id);
            List<string> result = JsonConvert.DeserializeObject<List<string>>(json);
            return View(result);
        }


    }
}
