using AutoMapper;
using VogCodeChallenge.API.Contracts;
using VogCodeChallenge.Data.Entities;
using VogCodeChallenge.Services.Models;

namespace VogCodeChallenge.API.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DepartmentModel, Department>();
            CreateMap<EmployeeModel, Employee>();
            CreateMap<DepartmentEntity, DepartmentModel>();
            CreateMap<EmployeeEntity, EmployeeModel>();
        }
    }
}
