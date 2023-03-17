using AutoMapper;
using Frutas.Core.Models;
using Frutas.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas.Core.Profiles
{
    public class FruitProfile : Profile
    {
        public FruitProfile()
        {
            CreateMap<FruitModel, FruitReadDto>();
        }
    }
}
