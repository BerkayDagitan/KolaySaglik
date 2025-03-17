using AutoMapper;
using EntityKatmani.DTOs;
using EntityKatmani.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmani.Mappers
{
    public class UrunMapper : Profile
    {
        public UrunMapper()
        {
            CreateMap<UrunGuncelleDTO, Urun>();
        }
    }
}
