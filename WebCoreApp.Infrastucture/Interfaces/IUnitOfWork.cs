using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApp.Infrastucture.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
