using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace DataLayer.Interfaces
{

    public interface IBaseData
    {
        List<Job> GetBulkData();
    }
}
