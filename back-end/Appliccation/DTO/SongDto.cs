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
    public class SongDto:IMapFrom<Song>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile Profile)
        {
            Profile.CreateMap<Song,SongDto>();
        }

    }
}
