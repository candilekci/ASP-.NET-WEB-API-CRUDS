﻿using hotelFinder.entities;
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController()
        {
            _hotelService = new HotelManager();
            
        }
        [HttpGet]

        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }
        [HttpGet("{id}")]

        public Hotel Get(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost]

        public Hotel Post([FromBody] Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]

        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }
        [HttpDelete ("{id}")]

        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
