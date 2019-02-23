using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IJobData
    {
        List<JobTitle> GetJobTitles();
        string GetJobTitle(int jobId);
        List<string> GetEmployeeNames(int jobId);
    }
}
