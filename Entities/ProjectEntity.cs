using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Abstract;

namespace Entities
{
    public class ProjectEntity : BaseEntity
    {
        /* название проекта,
        — название компании-заказчика,
        — название компании-исполнителя,
        — данные о сотруднике (имя, фамилия, отчество, e-mail человека),
        — данные о руководителе проекта,
        — данные об исполнителях проекта,
        — даты начала и окончания проекта,
        — приоритет проекта (целочисленный). */
        public int Id { get; set; }
        public string ProjectName { get; set; }
        //public string CustomerCompanyName { get; set; }
        //public string ExecutorCompanyName { get; set; }        
        //public DateTime StartProj { get; set; }
        //public DateTime EndProj { get; set; }
        //public int ProjPriority { get; set; }
        public virtual IQueryable<UserEntity> Users { get; set; }
    }
}
