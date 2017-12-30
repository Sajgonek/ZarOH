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
            Mapper.Initialize(c =>
            {
                c.CreateMap<Customer, CustomerDto>();
                c.CreateMap<CustomerDto, Customer>();
                c.CreateMap<Room, RoomDto>();
                c.CreateMap<RoomDto, Room>();
                c.CreateMap<MembershipType, MembershipTypeDto>();
                c.CreateMap<MembershipTypeDto, MembershipType>();
                c.CreateMap<RoomType, RoomTypeDto>();
                c.CreateMap<RoomTypeDto, RoomType>();
            });
        }
    }
}