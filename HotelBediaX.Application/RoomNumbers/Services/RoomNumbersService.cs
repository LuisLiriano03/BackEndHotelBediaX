using AutoMapper;
using HotelBediaX.Application.GendersType.DTOs;
using HotelBediaX.Application.IdentificationsType.Exceptions;
using HotelBediaX.Application.RoomNumbers.DTOs;
using HotelBediaX.Application.RoomNumbers.Exceptions;
using HotelBediaX.Application.RoomNumbers.Interfaces;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.RoomNumbers.Services
{
    public class RoomNumbersService : IRoomNumbersService
    {
        public readonly IGenericRepository<RoomNumber> _roomNumberRepository;
        public readonly IMapper _mapper;

        public RoomNumbersService(IGenericRepository<RoomNumber> roomNumberRepository, IMapper mapper)
        {
            _roomNumberRepository = roomNumberRepository;
            _mapper = mapper;
        }

        public async Task<List<GetRoomNumbers>> GetAllRoomNumbersAsync()
        {

            try
            {
                var departments = await _roomNumberRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetRoomNumbers>>(departments.ToList());

            }
            catch
            {
                throw new GetRoomNumbersFailedException();
            }


        }
    }
}
