using Application.Common.Mapping;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ConcertDto:IMapFrom<Concert>
    {

        public void Mapping(Profile Profile)
        {
            Profile.CreateMap<Concert, ConcertDto>();
        }
    }
}
