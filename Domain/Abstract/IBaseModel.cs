using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Abstract
{
    public interface IBaseModel
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
