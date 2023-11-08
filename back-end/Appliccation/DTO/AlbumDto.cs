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
    public class AlbumDto: IMapFrom<Album>
    {
        public int Id { get; set; }
        public string Titre {  get; set; }
        public string Description { get; set; }
        public List<SongDto> songList {get;set;}

        public void Mapping(Profile Profile)
        {
            Profile.CreateMap<Album, AlbumDto>();
        }
    }
}
