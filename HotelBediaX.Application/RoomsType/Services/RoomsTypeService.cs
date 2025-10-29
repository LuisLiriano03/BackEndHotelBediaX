using AutoMapper;
using HotelBediaX.Application.RoomNumbers.DTOs;
using HotelBediaX.Application.RoomNumbers.Exceptions;
using HotelBediaX.Application.RoomsType.DTOs;
using HotelBediaX.Application.RoomsType.Exceptions;
using HotelBediaX.Application.RoomsType.Interfaces;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomsType.Services
{
    public class RoomsTypeService : IRoomsTypeService
    {
        public readonly IGenericRepository<RoomType> _roomTypeRepository;
        public readonly IMapper _mapper;

        public RoomsTypeService(IGenericRepository<RoomType> roomTypeRepository, IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GetRoomsType>> GetAllRoomsTypeAsync()
        {

            try
            {
                var departments = await _roomTypeRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetRoomsType>>(departments.ToList());

            }
            catch
            {
                throw new GetRoomsTypeFailedException();
            }



        }
    }
}
