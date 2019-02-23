using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace DataLayer
{
    public class BaseData : IBaseData
    {
        public List<Job> GetBulkData()
        {
            return new List<Job>
            {
                new Job
                {
                    Id =1, Title="Actress",
                    Employees =new List<Employee>
                    {
                        new Employee { Id=1, Name="Isabelle Huppert", City="Paris", Country="France" },
                        new Employee { Id=2, Name="Greta Gervig", City="New York", Country="USA" },
                        new Employee { Id=3, Name="Diane Kruger", City="Berlin", Country="Germany" },
                    }
                },
                new Job
                {
                    Id =2, Title="Director",
                    Employees =new List<Employee>
                    {
                        new Employee { Id=1, Name="Stanley Kubrick", City="New York", Country="USA" },
                        new Employee { Id=2, Name="Ingmar Bergman", City="Stockholm", Country="Sweden" },
                        new Employee { Id=3, Name="Michael Haneke", City="Salzburg", Country="Austria" },
                        new Employee { Id=4, Name="Jean-luc Goddard", City="Paris", Country="France" },
                    }
                }
            };
        }
    }
}
