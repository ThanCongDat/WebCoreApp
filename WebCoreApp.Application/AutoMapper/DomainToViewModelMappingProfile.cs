using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Application.ViewModels;
using WebCoreApp.Data.Entities;

namespace WebCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
