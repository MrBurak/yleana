using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Interfaces;
using DataLayer.Models;
using System.Linq;

namespace DataLayer
{
    public class JobData : IJobData
    {
        public IBaseData _basedata;
        public JobData(IBaseData basedata)
        {
            _basedata = basedata;
        }

      

        public List<JobTitle> GetJobTitles()
        {
            List<JobTitle> titles = new List<JobTitle>(); 
            foreach (var data in _basedata.GetBulkData())
            {
                titles.Add(new JobTitle { Title = data.Title, Id = data.Id });
                
            }
            return titles;
         
        }
        public List<string> GetEmployeeNames(int jobId)
        {

            return _basedata.GetBulkData().Where(x=> x.Id==jobId).SelectMany(x => x.Employees.Select(y => y.Name)).ToList();
        }
        public string GetJobTitle(int jobId)
        {
            if (_basedata.GetBulkData().Any(x => x.Id == jobId))
            {
                return _basedata.GetBulkData().First(x => x.Id == jobId).Title;
            }
            return string.Empty;
            
        }
    }
}
