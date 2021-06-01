using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Abstract
{
    public abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
