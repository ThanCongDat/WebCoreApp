using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeletec { set; get; }
    }
}
