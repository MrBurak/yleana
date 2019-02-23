using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
