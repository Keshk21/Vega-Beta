using System.Linq;
using AutoMapper;
using Vega.Controllers.Resources;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Domian to Api resources 
            CreateMap<Make,MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle,VehicleResource>()
            .ForMember (vr=> vr.Contact,opt=> opt.MapFrom(v=> new ContactResource{Name=v.ContactName, Email=v.ContactEmail,Phone=v.ContactPhone,Adress=v.ContactAdress }))
            .ForMember(vr=> vr.Features, opt=> opt.MapFrom(v=> v.Features.Select(vf=> vf.FeatureId)));
                
        

            // Api Resourced to Domain

            CreateMap<VehicleResource,Vehicle>()
            .ForMember(v => v.ContactName, opt=> opt.MapFrom(vr=> vr.Contact.Name))
            .ForMember(v => v.ContactEmail, opt=> opt.MapFrom(vr=> vr.Contact.Email))
             .ForMember(v => v.ContactPhone, opt=> opt.MapFrom(vr=> vr.Contact.Phone))
            .ForMember(v => v.ContactAdress, opt=> opt.MapFrom(vr=> vr.Contact.Adress));
            //.ForMember(v => v.Features, opt=> opt.MapFrom(vr=> vr.Features.Select(id=> new VehcileFeature{FeatureId=id})));




            
        }
    }
}