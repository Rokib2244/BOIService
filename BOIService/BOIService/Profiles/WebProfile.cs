using AutoMapper;
using BOIService.Models;
using BOIService.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOIService.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<CreateCustomerModel, Customer>().ReverseMap();
        }
    }
}
