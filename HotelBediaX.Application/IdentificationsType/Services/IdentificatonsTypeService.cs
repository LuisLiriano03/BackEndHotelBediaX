using AutoMapper;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.Destinations.Exceptions;
using HotelBediaX.Application.IdentificationsType.DTOs;
using HotelBediaX.Application.IdentificationsType.Exceptions;
using HotelBediaX.Application.IdentificationsType.Interfaces;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.IdentificationsType.Services
{
    public class IdentificatonsTypeService : IdentificationTypeService
    {

        public readonly IGenericRepository<IdentificationType> _dentificationTypeRepository;
        public readonly IMapper _mapper;

        public IdentificatonsTypeService(IGenericRepository<IdentificationType> dentificationTypeRepository, IMapper mapper)
        {
            _dentificationTypeRepository = dentificationTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GetIdentificationsType>> GetAllIdentificationTypeAsync()
        {
            try
            {
                var departments = await _dentificationTypeRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetIdentificationsType>>(departments.ToList());

            }
            catch
            {
                throw new GetIdentificationsTypeFailedException();
            }
        }
    }
}
