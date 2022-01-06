using AutoMapper;
using Nubimetrics.DalEntities.SearchItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Composition
{
    public class MappingBuilder : Profile
    {
        public MappingBuilder()
        {
            CreateMap<Item, ItemDto>()
                .ForMember(dest => dest.site_id, opt => opt.MapFrom(src => src.site_id))
                .ForMember(dest => dest.country_default_time_zone, opt => opt.MapFrom(src => src.country_default_time_zone))
                .ForMember(dest => dest.query, opt => opt.MapFrom(src => src.query))
                .ForMember(dest => dest.paging, opt => opt.MapFrom(src => src.paging))
                .ForMember(dest => dest.results, opt => opt.MapFrom(src => src.results))
                .ForMember(dest => dest.sort, opt => opt.MapFrom(src => src.sort))
                .ForMember(dest => dest.available_sorts, opt => opt.MapFrom(src => src.available_sorts))
                .ForMember(dest => dest.filters, opt => opt.MapFrom(src => src.filters))
                .ForMember(dest => dest.available_filters, opt => opt.MapFrom(src => src.available_filters));
            CreateMap<Result, ResultDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.site_id, opt => opt.MapFrom(src => src.site_id))
                .ForMember(dest => dest.title, opt => opt.MapFrom(src => src.title))
                .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.price))
                .ForMember(dest => dest.seller, opt => opt.MapFrom(src => src.seller))
                .ForMember(dest => dest.permalink, opt => opt.MapFrom(src => src.permalink));
        }
    }
}
