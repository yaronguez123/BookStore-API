using BookStore_API.Data;
using BookStore_API.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Mappings
{
    public class Maps : profile
    {
        public Maps()
        {

            CreateMap<Author, AuthorDTO>().ReverseMap();
        }
        
    }
}
