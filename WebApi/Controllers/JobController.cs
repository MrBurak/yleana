using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        IJobData _repostroryJob;
        public JobController(IJobData repostroryJob)
        {
            _repostroryJob = repostroryJob;
        }

      
        [HttpGet]
        [Route("titles")]
        public async Task<IActionResult> GetJobTitles()
        {
            return Ok(await Task.Run(() => _repostroryJob.GetJobTitles()));
        }

        [HttpGet]
        [Route("title/{id}")]
        public async Task<IActionResult> GetJobTitle(int Id)
        {
            return Ok(await Task.Run(() => _repostroryJob.GetJobTitle(Id)));
        }


        [HttpGet]
        [Route("employees/{id}")]
        public async Task<IActionResult> GetEmployeeNames(int Id)
        {
            return Ok(await Task.Run(() => _repostroryJob.GetEmployeeNames(Id)));
        }
    }
}