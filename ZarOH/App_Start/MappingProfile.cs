using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZarOH.Dtos;
using ZarOH.Models;

namespace ZarOH.App_Start
{
    public class MappingProfile
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(c =>
            {
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<CustomerDto, Customer>();
                c.CreateMap<Room, RoomDto>();
                c.CreateMap<RoomDto, Room>();
            });
        }
    }
}