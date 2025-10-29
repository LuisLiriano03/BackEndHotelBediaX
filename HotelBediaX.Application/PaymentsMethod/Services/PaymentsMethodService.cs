using AutoMapper;
using HotelBediaX.Application.PaymentsMethod.DTOs;
using HotelBediaX.Application.PaymentsMethod.Interfaces;
using HotelBediaX.Application.RoomsType.DTOs;
using HotelBediaX.Application.RoomsType.Exceptions;
using HotelBediaX.Domain.Entities;
using HotelBediaX.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBediaX.Application.PaymentsMethod.Services
{
    public class PaymentsMethodService : IPaymentsMethodService
    {
        public readonly IGenericRepository<PaymentMethod> _paymentMethodRepository;
        public readonly IMapper _mapper;

        public PaymentsMethodService(IGenericRepository<PaymentMethod> paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }

        public async Task<List<GetPaymentsMethod>> GetAllPaymentsMethodAsync()
        {


            try
            {
                var departments = await _paymentMethodRepository.VerifyDataExistenceAsync();
                return _mapper.Map<List<GetPaymentsMethod>>(departments.ToList());

            }
            catch
            {
                throw new GetRoomsTypeFailedException();
            }


        }
    }
}
