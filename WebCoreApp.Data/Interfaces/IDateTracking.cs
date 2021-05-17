using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DataCreated { set; get; }
        DateTime DateModified { set; get; }
    }
}
