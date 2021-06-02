using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Abstract;

namespace Entities
{
    public class ProjectEntity : BaseEntity
    {
        /* название проекта, +
        — название компании-заказчика, +
        — название компании-исполнителя, +       
        — даты начала и окончания проекта, +
        — приоритет проекта (целочисленный). */          
        public string ProjectName { get; set; }
        public string CompanyCustomer { get; set; }
        public string CompanyExecutor { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectEnd { get; set; }
        public int ProjectPriority { get; set; }        
    }
}
