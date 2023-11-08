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
    public class AcutalitéDto : IMapFrom<ActualitéDto>
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DatedeSortie { get; set; }

        public void Mapping(Profile Profile)
        {
            Profile.CreateMap<ActualitéDto, AcutalitéDto>();
        }
    }
}
