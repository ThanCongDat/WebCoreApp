using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Data.Entities;
using WebCoreApp.Infrastucture.Interfaces;

namespace WebCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
