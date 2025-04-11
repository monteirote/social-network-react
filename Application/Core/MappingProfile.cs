using AutoMapper;
using Domain;
using System;

namespace Application.Core;
public class MappingProfile : Profile {

    public MappingProfile() {
        CreateMap<Activity, Activity>();
    }

}

