﻿using hotelFinder.entities;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager ()
        {
            _hotelRepository = new HotelRepository();
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

      

        public Hotel GetHotelById(int id)
        {
            return _hotelRepository.GetHotelById(id);
            
        }


       
        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
