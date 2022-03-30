using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO = BOIService.Training.BusinessObjects;
using EO = BOIService.Training.Entities;

namespace BOIService.Training.Profiles
{
  public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Customer, BO.Customer>().ReverseMap();
        }
    }
}
