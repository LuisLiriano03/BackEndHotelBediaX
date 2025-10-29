using AutoMapper;
using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Application.GendersType.Interfaces;
using HotelBediaX.Application.IdentificationsType.DTOs;
using HotelBediaX.Application.IdentificationsType.Exceptions;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.GendersType.Services
{
    public class GendersTypeServices : IGendersTypeService
    {


        public readonly IGenericRepository<GenderType> _genderTypeRepository;
        public readonly IMapper _mapper;

        public GendersTypeServices(IGenericRepository<GenderType> genderTypeRepository, IMapper mapper)
        {
            _genderTypeRepository = genderTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GetGendersType>> GetAllGenderTypeAsync()
        {
            try
            {
                var departments = await _genderTypeRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetGendersType>>(departments.ToList());

            }
            catch
            {
                throw new GetIdentificationsTypeFailedException();
            }
        }
    }
}
