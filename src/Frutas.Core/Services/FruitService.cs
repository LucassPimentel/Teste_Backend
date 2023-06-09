﻿using AutoMapper;
using Frutas.Core.Models;
using Frutas.Core.Models.Dtos;
using Frutas.Core.Repositories.Interfaces;

namespace Frutas.Core.Services
{
    public class FruitService
    {
        private readonly IFruitRepository _fruitRepository;
        private readonly IMapper _mapper;

        public FruitService(IFruitRepository fruitRepository, IMapper mapper)
        {
            _fruitRepository = fruitRepository;
            _mapper = mapper;
        }

        public List<FruitModel> GetAllFruits()
        {
            try
            {
                var fruits = _fruitRepository.GetFruits();

                return fruits;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
