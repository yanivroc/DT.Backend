using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/timezone")]
public class TimeZoneController : CrudControllerBase<DT.Domain.Entities.TimeZone, TimeZoneDto, CreateTimeZoneDto, UpdateTimeZoneDto>
{
    public TimeZoneController(IGenericRepository<DT.Domain.Entities.TimeZone> repo, IMapper mapper) : base(repo, mapper) { }
}
