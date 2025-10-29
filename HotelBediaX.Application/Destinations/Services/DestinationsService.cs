using AutoMapper;
using HotelBediaX.Application.Destinations.DTOs;
using HotelBediaX.Application.Destinations.Exceptions;
using HotelBediaX.Application.Destinations.Interfaces;
using HotelBediaX.Domain;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.Destinations.Services
{
    public class DestinationsService : IDestinationsService
    {
        public readonly IGenericRepository<Destination> _destinationRepository;
        public readonly IMapper _mapper;

        public DestinationsService(IGenericRepository<Destination> destinationRepository, IMapper mapper)
        {
            _destinationRepository = destinationRepository;
            _mapper = mapper;
        }

        public async Task<List<GetDestination>> GetAllDestinationAsync()
        {
            try
            {
                var departments = await _destinationRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetDestination>>(departments.ToList());

            }
            catch
            {
                throw new GetDestinationFailedException();
            }
        }
    }
}
